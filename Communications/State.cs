using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Communications
{
    public class State : DomainObject
    {
        public Guid CountryID { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<State>();
            }
        }

        #region Navigation Properties
        public virtual IList<City> Cities { get; set; }
        public virtual IList<Address> Addresses { get; set; }
        public virtual Country Country { get; set; }
        #endregion
    }
}
