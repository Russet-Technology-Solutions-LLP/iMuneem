using Russet.iMuneem.Base;
using System.Collections.Generic;

namespace Russet.iMuneem.Communications
{
    public class City : DomainObject
    {
        public string Name { get; set; }
        public string Code { get; set; }

        #region Navigation Properties
        public virtual IList<ZipCode> ZipCodes { get; set; }
        #endregion
    }
}
