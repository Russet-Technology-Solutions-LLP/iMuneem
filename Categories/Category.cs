using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Categories
{
    public class Category : DomainObject
    {
        public Guid TypeID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Category>();
            }
        }

        #region Navigation Properties
        public virtual CategoryType Type { get; set; }
        public virtual IList<Group> Groups { get; set; }
        #endregion
    }
}
