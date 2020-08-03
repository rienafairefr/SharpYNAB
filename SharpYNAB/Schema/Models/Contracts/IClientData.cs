namespace SharpYNAB.Schema.Models.Contracts
{
    public interface IClientData<T>
    {
        int StartingDeviceKnowledge { get; set; }
        int EndingDeviceKnowledge { get; set; }
        int DeviceKnowledgeOfServer { get; set; }
        T Changed { get; set; }
    }
}