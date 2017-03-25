using Russet.iMuneem.Base;
using Russet.iMuneem.Organization;
using System;

namespace Russet.iMuneem.Finance
{
    public class FinancialYear : DomainObject
    {
        public Guid CompanyID { get; set; }

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
                return Validate<FinancialYear>();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }

        #region Navigation Properties
        public virtual FinancialBook FinancialBook { get; set; }
        public virtual Company Company { get; set; }
        #endregion
    }
}
