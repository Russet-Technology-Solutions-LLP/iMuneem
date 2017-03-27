﻿using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Products
{
    public class ProductMovHistory : DomainObject
    {
        public Guid ProductBatchID { get; set; }
        
        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ProductMovHistory>();
            }
        }

        #region Navigation
        public virtual ProductBatch ProductBatch { get; set; }
        #endregion
    }
}
