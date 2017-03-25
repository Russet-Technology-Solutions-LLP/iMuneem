using Russet.iMuneem.Base;
using Russet.iMuneem.Finance;
using Russet.iMuneem.Organization;
using System.Collections.Generic;

namespace Russet.iMuneem.Communications
{
    public class Country : DomainObject
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Currency DefaultCurrency
        {
            get
            {
                if(Currencies != null)
                    foreach(Currency curr in Currencies)
                    {
                        if (curr.IsDefault)
                            return curr;
                        return null;
                    }
                return null;
            }
        }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Country>();
            }
        }

        #region Navigation Properties
        public virtual IList<State> States { get; set; }
        public virtual IList<Currency> Currencies { get; set; }
        public virtual IList<Company> Companies { get; set; }
        public virtual IList<Address> Addresses { get; set; }
        #endregion
    }
}
