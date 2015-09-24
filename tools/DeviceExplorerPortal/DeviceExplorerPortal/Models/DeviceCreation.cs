namespace DeviceExplorerPortal.Models
{
    public class DeviceCreation
    {
        public string Id { get; set; }
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
        public bool AutoGenerateId { get; set; }
        public bool AutoGenerateKey { get; set; }
    }
}