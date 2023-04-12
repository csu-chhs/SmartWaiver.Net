namespace SmartWaiver.Net.Objects
{
    /// <summary>
    /// Waiver template information
    /// </summary>
    public class Template
    {
        public Template() { }

        /// <summary>
        /// Unique ID of waiver template
        /// </summary>
        public string TemplateId { get; set; }
        /// <summary>
        /// Title of waiver template
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Published version of waiver template
        /// </summary>
        public int PublishedVersion { get; set; }
        /// <summary>
        /// Date of waiver template was published
        /// </summary>
        public DateTime PublishedOn { get; set; }
        /// <summary>
        /// Link to web version of waiver template
        /// </summary>
        public Uri WebUrl { get; set; }
        /// <summary>
        /// Link to kiosk version of waiver template
        /// </summary>
        public Uri KioskUrl { get; set; }
        /// <summary>
        /// Link to any of the vanity urls for the template
        /// </summary>
        public List<Uri> VanityUrls { get; set; }
        /// <summary>
        /// An object containing information about the template level webhook or null if no webhook is set up
        /// </summary>
        public Webhook Webhook { get; set; }        
    }
}
