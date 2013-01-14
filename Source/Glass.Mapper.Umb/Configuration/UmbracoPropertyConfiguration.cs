﻿using Glass.Mapper.Configuration;

namespace Glass.Mapper.Umb.Configuration
{
    public class UmbracoPropertyConfiguration : FieldConfiguration
    {
        /// <summary>
        /// The alias for the property  to use if it is different to the property name
        /// </summary>
        public string PropertyAlias { get; set; }

        /// <summary>
        /// The ID of the property when used in a code first scenario 
        /// </summary>
        public int PropertyId { get; set; }

        /// <summary>
        /// Options to override the behaviour of certain properties.
        /// </summary>
        public UmbracoPropertySettings Setting { get; set; }

        #region Code First Properties

        /// <summary>
        /// Indicates the property should be used as part of a code first template
        /// </summary>
        public bool CodeFirst { get; set; }

        /// <summary>
        /// The type of property to create when using Code First
        /// </summary>
        public UmbracoDataType DataType { get; set; }

        /// <summary>
        /// The name of the tab this property will appear in when using code first.
        /// </summary>
        public string DocumentTab { get; set; }

        /// <summary>
        /// The name of the property
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// The description for the property
        /// </summary>
        public string PropertyDescription { get; set; }

        /// <summary>
        /// Indicates that the property is mandatory
        /// </summary>
        public bool PropertyIsMandatory { get; set; }

        /// <summary>
        /// The validation for the property
        /// </summary>
        public string PropertyValidation { get; set; }

        #endregion
    }
}