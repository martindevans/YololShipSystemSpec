using System;

namespace YololShipSystemSpec.Attributes
{
    /// <summary>
    /// Mark a property as a remap from a Yolol field (with the same name as the property) to a new name (with the value of the property)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class FieldRemapAttribute
        : Attribute
    {
    }
}
