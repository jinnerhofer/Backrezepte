using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using Backrezepte.Core.Models;
using MvvmCross.Logging;
using MvvmCross;
using System.Diagnostics;

namespace Backrezepte.Core.Services
{
    public class XmlData : IRezeptDatenService
    {
        private string Filename { get; set; } = "rezepte.xml";
        private string Dir { get; set; } = Directory.GetCurrentDirectory();

        private string RezeptFilePath { get; set; }

        private XElement rootElement;

        private List<IRezeptItem> rezepte;

        private readonly IMvxLog _log;

        public XmlData()
        {
            var logProvider = Mvx.IoCProvider.Resolve<IMvxLogProvider>();
            this._log = logProvider.GetLogFor("XmlData");

            this.RezeptFilePath = Path.Combine(this.Dir, this.Filename);

            Debug.WriteLine(this.RezeptFilePath);

            if (File.Exists(this.RezeptFilePath))
            {
                this.rootElement = XElement.Load(this.RezeptFilePath);

                var rzt = from item in this.rootElement.Descendants("rezept")
                          select new RezeptItem()
                          {
                              RezeptId = (string)item.Attribute("id"),
                              Rezeptname = (string)item.Attribute("name"),
                              Rezeptanleitung = (string)item.Attribute("anleitung")
                          };

                this.rezepte = rzt.ToList<IRezeptItem>();
            }

            else
            {
                this.rootElement = new XElement("rezepte");
                this.rezepte = new List<IRezeptItem>();
            }
        }

        public bool Add(IRezeptItem rezept)
        {
            var rzt = new XElement("rezept");
            rzt.Add(new XAttribute("id", rezept.RezeptId));
            rzt.Add(new XAttribute("name", rezept.Rezeptname));
            rzt.Add(new XAttribute("anleitung", rezept.Rezeptanleitung));
            this.rootElement.Add(rzt);

            this.rezepte.Add(rezept);

            var res = this.Save();
            return res;

        }

        public List<IRezeptItem> All()
        {
            return this.rezepte;
        }

        public bool Delete(IRezeptItem rezept)
        {
            var items = from rzt in this.rootElement.Descendants("rezept")
                        where (string)rzt.Attribute("id") == rezept.RezeptId
                        select rzt;
            items.Remove();
            return this.Save();
        }

        public bool Save()
        {
            try
            {
                this.rootElement.Save(this.RezeptFilePath);
                return true;
            }
            catch (IOException ioe)
            {
                return false;
            }
        }

    }
}
