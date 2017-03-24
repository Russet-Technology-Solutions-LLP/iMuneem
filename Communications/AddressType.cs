using Russet.iMuneem.Base;
using System.Collections.Generic;

namespace Russet.iMuneem.Communications
{
    public class AddressType : DomainObject
    {
        ///<summary>
        /// Gets or sets the name of contact type.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<AddressType>();
            }
        }

        #region Navigation Properties
        public virtual IList<Address> Addresses { get; set; }
        #endregion
    }
}
