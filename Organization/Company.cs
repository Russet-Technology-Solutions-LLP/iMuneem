using Russet.iMuneem.Base;
using Russet.iMuneem.Communications;
using Russet.iMuneem.Finance;
using System.Collections.Generic;

namespace Russet.iMuneem.Organization
{
    public class Company : DomainObject
    {
        public string Name { get; set; }
        public string MailingName { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Company>();
            }
        }

        #region Navigation Properties
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
        public virtual Currency BaseCurrency { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Country Country { get; set; }
        public virtual IList<FinancialYear> FinancialYears { get; set; }
        #endregion
    }
}
