using Russet.iMuneem.Base;
using Russet.iMuneem.Communications;
using Russet.iMuneem.Finance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Russet.iMuneem.Organization
{
    public class Company : DomainObject
    {
        public Guid CurrencyID { get; set; }
        public Guid CountryID { get; set; }
        public Guid StateID { get; set; }
        public Guid CityID { get; set; }
        public Guid ZipCodeID { get; set; }

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

        #region Methods
        ///<summary>
        ///Gets the default contact.
        /// </summary>
        /// <value>The default contact.</value>
        public Contact DefaultContact
        {
            get
            {
                if (Contacts == null)
                {
                    return null;
                }
                return Contacts.Where(x => x.IsDefault).FirstOrDefault();
            }
        }

        ///<summary>
        /// Adds the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void AddContact(Contact contact)
        {
            if (Contacts == null)
            {
                Contacts = new List<Contact>();
            }

            // If there are not default address, set this one as default
            if (Contacts.Where(x => x.IsDefault).Count() < 1)
            {
                contact.IsDefault = true;
            }

            // If this is the new default address
            if (contact.IsDefault)
            {
                foreach (Contact cont in Contacts)
                {
                    cont.IsDefault = false;
                }
            }

            // If the address is not already in the list
            if (!Contacts.Any(x => x.PrimaryKey == contact.PrimaryKey))
            {
                Contacts.Add(contact);
                contact.Company = this;
            }
        }

        ///<summary>
        /// Removes the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void RemoveContact(Contact contact)
        {
            if (Contacts == null)
            {
                return;
            }

            Contacts.Remove(contact);

            if (contact.IsDefault)
            {
                Contacts.FirstOrDefault().IsDefault = true;
            }
        }

        ///<summary>
        ///Gets the default address.
        /// </summary>
        /// <value>The default address.</value>
        public Address DefaultAddress
        {
            get
            {
                if (Addresses == null)
                {
                    return null;
                }
                return Addresses.Where(x => x.IsDefault).FirstOrDefault();
            }
        }

        ///<summary>
        /// Adds the address.
        /// </summary>
        /// <param name="contact">The address.</param>
        public void AddAddress(Address address)
        {
            if (Addresses == null)
            {
                Addresses = new List<Address>();
            }

            // If there are not default address, set this one as default
            if (Addresses.Where(x => x.IsDefault).Count() < 1)
            {
                address.IsDefault = true;
            }

            // If this is the new default address
            if (address.IsDefault)
            {
                foreach (Address addr in Addresses)
                {
                    addr.IsDefault = false;
                }
            }

            // If the address is not already in the list
            if (!Addresses.Any(x => x.PrimaryKey == address.PrimaryKey))
            {
                Addresses.Add(address);
                address.Company = this;
            }
        }

        ///<summary>
        /// Removes the address.
        /// </summary>
        /// <param name="contact">The address.</param>
        public void RemoveAddress(Address address)
        {
            if (Addresses == null)
            {
                return;
            }

            Addresses.Remove(address);

            if (address.IsDefault)
            {
                Addresses.FirstOrDefault().IsDefault = true;
            }
        }

        ///<summary>
        /// Adds the financial year.
        /// </summary>
        /// <param name="year">The financial year.</param>
        public void AddFinancialYear(FinancialYear fnYear)
        {
            if (FinancialYears == null)
            {
                FinancialYears = new List<FinancialYear>();
            }

            // If there are not default year, set this one as default
            if (FinancialYears.Where(x => x.IsDefault).Count() < 1)
            {
                fnYear.IsDefault = true;
            }

            // If this is the new default year
            if (fnYear.IsDefault)
            {
                foreach (FinancialYear fy in FinancialYears)
                {
                    fy.IsDefault = false;
                }
            }

            // If the year is not already in the list
            if (!FinancialYears.Any(x => x.PrimaryKey == fnYear.PrimaryKey))
            {
                FinancialYears.Add(fnYear);
                fnYear.Company = this;
            }
        }

        ///<summary>
        /// Removes the financial year.
        /// </summary>
        /// <param name="year">The year.</param>
        public void RemoveFinancialYear(FinancialYear fnYear)
        {
            if (FinancialYears == null)
            {
                return;
            }

            FinancialYears.Remove(fnYear);

            if (fnYear.IsDefault)
            {
                FinancialYears.FirstOrDefault().IsDefault = true;
            }
        }
        #endregion

        #region Navigation Properties
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual City City { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public virtual IList<FinancialYear> FinancialYears { get; set; }
        #endregion
    }
}
