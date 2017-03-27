using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Products
{
    public class ProductPicture : DomainObject
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        // Store image in binary format in database.
        public byte[] Picture { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductPicture>();
            }
        }

        #region Navigation
        public virtual Product Product { get; set; }
        #endregion
    }
}
