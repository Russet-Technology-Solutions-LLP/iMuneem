using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Products
{
    public class Product : DomainObject
    {
        public Guid CategoryID { get; set; }
        public Guid ProductTypeID { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Product>();
            }
        }

        #region Navigation Properties
        public virtual ProductCategory Category { get; set; }
        public virtual ProductType Type { get; set; }
        public virtual IList<ProductPicture> Pictures { get; set; }
        public virtual IList<ProductMeasurement> Measurements { get; set; }
        public virtual IList<ProductMaterial> Materials { get; set; }
        public virtual IList<ProductBatch> Batches { get; set; } 

        #endregion
    }
}
