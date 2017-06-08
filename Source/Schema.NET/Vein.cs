namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
    [DataContract]
    public class Vein : Vessel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Vein";
    }
}