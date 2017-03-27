using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Services
{
    public class Service : DomainObject
    {
        public Guid CategoryID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }

        public override bool IsValid
        {
            get
            {
                return Validate<Service>();
            }
        }

        #region Navigation
        public virtual ServiceCategory Category { get; set; }
        public virtual IList<ServicePrice> Prices { get; set; } 
        #endregion
    }
}
