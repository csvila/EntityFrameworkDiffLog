﻿using System;

namespace HodStudio.EfDiffLog.Model
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class LoggedEntityAttribute : Attribute
    {
        public const string DefaultIdPropertyName = "Id";

        /// <summary>
        /// Defines that the entity will be logged when using the EfDiffLog.
        /// It will use the default id property name ("Id").
        /// If your class has a different id property name, use the overload, where you can provide the Id property name.
        /// </summary>
        public LoggedEntityAttribute() : this(DefaultIdPropertyName) { }

        /// <summary>
        /// Defines that the entity will be logged when using the EfDiffLog.
        /// </summary>
        /// <param name="idPropertyName">Id Property name to get the id from the entity</param>
        public LoggedEntityAttribute(string idPropertyName) => IdPropertyName = idPropertyName;

        public string IdPropertyName { get; set; }
    }
}
