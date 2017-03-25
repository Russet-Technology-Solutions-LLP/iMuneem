using Russet.iMuneem.Base;
using System.Collections.Generic;

namespace Russet.iMuneem.Transactions
{
    public class VoucherType : DomainObject
    {
        public string Name { get; set; }
        public string Abbrebiation { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<VoucherType>();
            }
        }

        #region Navigation Properties
        public virtual IList<Voucher> Vouchers { get; set; }
        #endregion
    }
}
