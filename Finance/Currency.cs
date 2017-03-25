using Russet.iMuneem.Base;
using Russet.iMuneem.Communications;
using Russet.iMuneem.Organization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Russet.iMuneem.Finance
{
    public class Currency : DomainObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

        public bool IsDefault { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Currency>();
            }
        }

        ///<summary>
        /// Adds the country.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void AddCountry(Country country)
        {
            if (Countries == null)
            {
                Countries = new List<Country>();
            }


            // If the address is not already in the list
            if (!Countries.Any(x => x.PrimaryKey == country.PrimaryKey))
            {
                Countries.Add(country);
                //country.AddCurrency(this);
            }
        }

        #region Navigation Properties
        public virtual IList<Company> Companies { get; set; }
        public virtual IList<Country> Countries { get; set; }
        #endregion
    }
}
