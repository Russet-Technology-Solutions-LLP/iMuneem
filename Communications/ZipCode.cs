using Russet.iMuneem.Base;
using Russet.iMuneem.Organization;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Communications
{
    public class ZipCode : DomainObject
    {
        public Guid CityID { get; set; }

        public string Code { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ZipCode>();
            }
        }

        #region Navigation Properties
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Company> Companies { get; set; }
        public virtual City City { get; set; }
        #endregion
    }
}
