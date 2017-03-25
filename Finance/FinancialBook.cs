using Russet.iMuneem.Base;
using System;

namespace Russet.iMuneem.Finance
{
    public class FinancialBook : DomainObject
    {
        public DateTime Starting { get; set; }
        public DateTime? Ending { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<FinancialBook>();
            }
        }

        #region Navigation Properties
        public virtual FinancialYear FinancialYear { get; set; }
        #endregion
    }
}
