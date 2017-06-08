namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An art gallery.
    /// </summary>
    [DataContract]
    public class ArtGallery : EntertainmentBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ArtGallery";
    }
}