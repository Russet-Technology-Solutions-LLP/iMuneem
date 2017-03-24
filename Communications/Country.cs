using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Communications
{
    public class Country : DomainObject
    {
        public string Name { get; set; }
        public string Code { get; set; }

        #region Navigation Properties
        public virtual IList<State> States { get; set; }
        #endregion
    }
}
