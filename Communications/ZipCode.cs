using Russet.iMuneem.Base;

namespace Russet.iMuneem.Communications
{
    public class ZipCode : DomainObject
    {
        public string Code { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<ZipCode>();
            }
        }
    }
}
