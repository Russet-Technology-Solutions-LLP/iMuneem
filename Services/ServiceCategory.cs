using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Services
{
    public class ServiceCategory : DomainObject
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override bool IsValid
        {
            get
            {
                return Validate<ServiceCategory>();
            }
        }

        #region Navigation
        public virtual IList<Service> Services { get; set; }
        #endregion
    }
}
