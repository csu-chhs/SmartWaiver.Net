namespace SmartWaiver.Net.Objects
{
    public class WaiverPhoto
    {
        /// <summary>
        /// Unique ID of signed waiver
        /// </summary>
        public string WaiverId { get; set; }
        /// <summary>
        /// Unique ID of template for this signed waiver
        /// </summary>
        public string TemplateId { get; set; }
        /// <summary>
        /// Title of waiver
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Date waiver was signed (ISO 8601 format)
        /// </summary>
        public DateTime CreatedOn { get; set; }
        public WaiverPhoto() { }
    }
}
