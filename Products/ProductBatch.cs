using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Products
{
    public class ProductBatch : DomainObject
    {
        public Guid ProductID { get; set; }
        // name or Batch no
        public string Name { get; set; }
        public string Description { get; set; }
        
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductBatch>();
            }
        }

        #region Navigation
        public virtual Product Product { get; set; }
        public virtual IList<ProductVendor> Vendors { get; set; }
        // Every batch of product can have many costs
        public virtual IList<ProductCost> Costs { get; set; }
        public virtual IList<ProductPrice> Prices { get; set; }
        public virtual IList<ProductSKU> SKUs { get; set; }
        public virtual IList<ProductMovHistory> MovementHistories { get; set; }
        public virtual IList<ProductOrderHistory> OrderHistories { get; set; }
        #endregion
    }
}
