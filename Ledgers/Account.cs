using Russet.iMuneem.Base;
using Russet.iMuneem.Categories;
using System;

namespace Russet.iMuneem.Ledgers
{
    public class Account : DomainObject
    {
        public Guid GroupID { get; set; }

        public string Name { get; set; }
        public string Alias { get; set; }
        public double OpeningBalance { get; set; }
        public double CloasingBalance { get; set; }
        public double Balance { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Account>();
            }
        }

        #region Navigation Properties
        public virtual Group Group { get; set; }
        #endregion
    }
}
