using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Russet.iMuneem.Base
{
    public class DomainObject
    {
        ///Constructor
        public DomainObject()
        {
            PrimaryKey = Guid.NewGuid();
        }

        ///<summary>
        ///Gets or sets the primary key.
        ///</summary>
        ///<value>The primary key.</value>
        [NotNullValidator(ErrorMessage = "The Primary Key can't be null or empty.")]
        public Guid PrimaryKey { get; set; }

        ///<summary>
        ///Gets the validation errors.
        ///</summary>
        ///<value>The errors.</value>
        [NotMapped]
        public ValidationResults Errors { get; private set; }

        ///<summary>
        ///Gets or sets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c>if this instance is valid; otherwise, <c>false</c>.</value>
        public virtual bool IsValid { get; private set; }

        ///<summary>
        ///Validates this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected bool Validate<T>()
        {
            Errors = ValidationFactory.CreateValidator<T>().Validate(this);
            return Errors.IsValid;
        }
    }
}
