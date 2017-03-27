using Russet.iMuneem.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Ledgers
{
    public class InventoryAccount : Account
    {
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<InventoryAccount>();
            }
        }

        #region Navigation
        public virtual IList<InventoryHistory> InventoryHistories { get; set; }
        #endregion
    }
}
