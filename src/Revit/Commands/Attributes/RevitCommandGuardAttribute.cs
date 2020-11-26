﻿using Onbox.Revit.VDev.Commands.Guards;
using System;
using System.Linq;

namespace Onbox.Revit.VDev.Commands.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class RevitCommandGuardAttribute : Attribute
    {
        private readonly Type revitCommandGuardType;

        public RevitCommandGuardAttribute(Type revitCommandGuardType)
        {
            this.revitCommandGuardType = revitCommandGuardType;
        }

        public Type GetCommandGuardType()
        {
            return this.revitCommandGuardType;
        }
    }
}