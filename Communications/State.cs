using Russet.iMuneem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russet.iMuneem.Communications
{
    public class State : DomainObject
    {
        public string Name { get; set; }
        public string Code { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<State>();
            }
        }

        #region Navigation Properties
        public virtual IList<City> Cities { get; set; }
        #endregion
    }
}
