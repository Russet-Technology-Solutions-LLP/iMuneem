using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Services
{
    public class ServicePrice : DomainObject
    {
        public Guid ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public override bool IsValid
        {
            get
            {
                return Validate<ServicePrice>();
            }
        }

        #region Navigation
        public virtual Service Service { get; set; }
        #endregion
    }
}
