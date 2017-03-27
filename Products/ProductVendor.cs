using Russet.iMuneem.Base;
using Russet.iMuneem.Vendors;
using System.Collections.Generic;

namespace Russet.iMuneem.Products
{
    public class ProductVendor : DomainObject
    {
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductVendor>();
            }
        }

        #region Navigation
        // one to one mapping
        public virtual Vendor Vendor { get; set; }
        // Many to Many relationship.
        public virtual IList<ProductBatch> ProductBatches { get; set; }
        #endregion
    }
}
