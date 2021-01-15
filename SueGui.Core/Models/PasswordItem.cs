using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    /// <summary>
    /// Create Password item
    /// </summary>
    public class PasswordItem : IPasswordItem
    {
        /// <summary>
        /// get or set service (url, app, ...)
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// get or set password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// get or set the datetime of the password
        /// </summary>
        public DateTime GeneratedDateTime { get; set; }
    }
}
