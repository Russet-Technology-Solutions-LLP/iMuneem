using Russet.iMuneem.Base;
using Russet.iMuneem.Ledgers;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Categories
{
    public class Group : DomainObject
    {
        public Guid CategoryID { get; set; }
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
                return Validate<Group>();
            }
        }

        #region Navigation Properties
        public virtual Category Category { get; set; }
        public virtual IList<Account> Accounts { get; set; }
        #endregion
    }
}
