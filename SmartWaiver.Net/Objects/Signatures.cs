namespace SmartWaiver.Net.Objects
{
    public class Signatures
    {
        public Signatures() { }

        public string waiverId { get; set; }
        public string templateId { get; set; }
        public string title { get; set; }
        public string createdOn { get; set; }

        public BodySignatures signatures { get; set; }
    }
}
