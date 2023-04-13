namespace SmartWaiver.Net.Objects
{
    public class CustomParticipantField
    {
        public CustomParticipantField() { }

        /// <summary>
        /// The custom participant field, each GUID is unique
        /// </summary>
        public List<GUID> GUID { get; set; }
    }
}
