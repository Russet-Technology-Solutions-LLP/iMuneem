using Russet.iMuneem.Base;
using System.Collections.Generic;

namespace Russet.iMuneem.Communications
{
    public class City : DomainObject
    {
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
                return Validate<City>();
            }
        }

        #region Navigation Properties
        public virtual IList<ZipCode> ZipCodes { get; set; }
        #endregion
    }
}
