using Russet.iMuneem.Base;
using Russet.iMuneem.Organization;
using System;
using System.ComponentModel.DataAnnotations;

namespace Russet.iMuneem.Communications
{
    public class Address : DomainObject
    {
        /*
         * ID's for relationships in database tables.
         */
        public Guid? CompanyID { get; set; }
        public Guid? TypeID { get; set; }
        public Guid? CountryID { get; set; }
        public Guid? StateID { get; set; }
        public Guid? CityID { get; set; }
        public Guid? ZipCodeID { get; set; }

        /// <summary>
        /// Gets or sets the address line1.
        /// </summary>
        /// <value>The address line1.</value>
        [Required(ErrorMessage = "The AddressLine1 is a mandatory field")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line2.
        /// </summary>
        /// <value>The address line2.</value>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public override bool IsValid
        {
            get
            {
                return Validate<Address>();
            }
        }

        #region Navigation Properties
        public virtual Company Company { get; set; }
        public virtual AddressType Type { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual City City { get; set; }
        public virtual ZipCode ZipCode { get; set; }

        #endregion
    }
}
