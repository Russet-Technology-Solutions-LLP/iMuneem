using Russet.iMuneem.Base;
using Russet.iMuneem.Communications;
using Russet.iMuneem.Organization;
using System;
using System.Collections.Generic;

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

        #region Navigation Properties
        public virtual IList<Company> Companies { get; set; }
        public virtual IList<Country> Countries { get; set; }
        #endregion
    }
}
