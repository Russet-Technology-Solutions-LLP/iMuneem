using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Finance
{
    public class FinancialYear : DomainObject
    {
        #region Navigation Properties
        public virtual FinancialBook FinancialBook { get; set; }
        #endregion
    }
}
