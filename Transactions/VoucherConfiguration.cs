using Russet.iMuneem.Base;
using System;

namespace Russet.iMuneem.Transactions
{
    public class VoucherConfiguration : DomainObject
    {
        public Guid VoucherID { get; set; }

        public string Name { get; set; }
        public string Configuration { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<VoucherConfiguration>();
            }
        }

        #region Navigation Properties
        public virtual Voucher Voucher { get; set; }
        #endregion
    }
}
