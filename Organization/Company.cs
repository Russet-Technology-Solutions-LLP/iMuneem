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

        #region Navigation Properties
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual IList<FinancialYear> FinancialYears { get; set; }
        #endregion
    }
}
