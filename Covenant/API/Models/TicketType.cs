// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TicketType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TicketType
    {
        [EnumMember(Value = "rC4")]
        RC4,
        [EnumMember(Value = "aes")]
        Aes
    }
    internal static class TicketTypeEnumExtension
    {
        internal static string ToSerializedValue(this TicketType? value)
        {
            return value == null ? null : ((TicketType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TicketType value)
        {
            switch( value )
            {
                case TicketType.RC4:
                    return "rC4";
                case TicketType.Aes:
                    return "aes";
            }
            return null;
        }

        internal static TicketType? ParseTicketType(this string value)
        {
            switch( value )
            {
                case "rC4":
                    return TicketType.RC4;
                case "aes":
                    return TicketType.Aes;
            }
            return null;
        }
    }
}
