﻿using Russet.iMuneem.Base;
using Russet.iMuneem.Organization;
using System;
using System.Collections.Generic;

namespace Russet.iMuneem.Categories
{
    public class Category : DomainObject
    {
        public Guid CompanyID { get; set; }
        public Guid TypeID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        // nature of accounts i.e debit or credit balances.
        public string Nature { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Category>();
            }
        }

        #region Navigation Properties
        public virtual CategoryType Type { get; set; }
        public virtual IList<Group> Groups { get; set; }
        public virtual Company Company { get; set; }
        #endregion
    }
}
