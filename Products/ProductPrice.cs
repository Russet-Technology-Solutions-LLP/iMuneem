using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Products
{
    public class ProductPrice : DomainObject
    {
        public Guid ProductBatchID { get; set; }
        // Name of price scheme e.g MRP, Wholesale etc
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductPrice>();
            }
        }

        #region Navigation
        public virtual ProductBatch ProductBatch { get; set; }
        #endregion
    }
}
