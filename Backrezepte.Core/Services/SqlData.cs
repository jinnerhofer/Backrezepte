using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Backrezepte.Core.Models;
using SQLite;
using System.Linq;

namespace Backrezepte.Core.Services
{
    public class SqlData : IRezeptService
    {
        private string Filename { get; set; } = "rezepte.db";
        private string Dir { get; set; } = Directory.GetCurrentDirectory();

        private string RezeptFilePath { get; set; }

        private SQLiteConnection Conn { get; set; }

        public SqlData()
        {
            this.RezeptFilePath = Path.Combine(this.Dir, this.Filename);

            var options = new SQLiteConnectionString(this.RezeptFilePath, true, key: "geheim");
            this.Conn = new SQLiteConnection(options);

            this.Conn.CreateTable<RezeptItem>();
        }

        public List<IRezeptItem> All()
        {

            var rezepte = from r in this.Conn.Table<RezeptItem>()
                          select new RezeptItem()
                          {
                              RezeptId = r.RezeptId,
                              Rezeptname = r.Rezeptname,
                              Rezeptanleitung = r.Rezeptanleitung,
          
                          };
            return rezepte.ToList<IRezeptItem>();
        }

        public bool Add(IRezeptItem rezept)
        {
            var count = this.Conn.Insert(rezept);
            return count > 0;
        }

        public bool Delete(IRezeptItem rezept)
        {
            var item = from rzt in this.Conn.Table<RezeptItem>()
                       where rzt.RezeptId == rezept.RezeptId
                       select rzt;
            var count = this.Conn.Delete(item);
            return count > 0;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
