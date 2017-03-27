using Russet.iMuneem.Base;
using Russet.iMuneem.Organization;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Categories
{
    public class CategoryType : DomainObject
    {
        public Guid CompanyID { get; set; }
        public string Type { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<CategoryType>();
            }
        }

        #region Navigation Properties
        public virtual IList<Category> Categories { get; set; }
        public virtual Company Company { get; set; }
        #endregion
    }
}
