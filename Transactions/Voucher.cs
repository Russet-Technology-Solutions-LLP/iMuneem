using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Transactions
{
    public class Voucher : DomainObject
    {
        public string Name { get; set; }
        public string Narration { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Voucher>();
            }
        }

        #region Navigation Properties
        public virtual VoucherType Type { get; set; }
        public virtual VoucherNumbering Numbering { get; set; }
        public virtual IList<VoucherConfiguration> Configurations { get; set; }
        #endregion
    }
}
