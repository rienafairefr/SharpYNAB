namespace SharpYNAB.Tests
{
    public class UnitTest1
    {
        public void TestMethod1()
        {
            var args = Utils.GetTestArgs();
            var client = ClientFactory.CreateClient(args);
            client.Sync();
        }
    }
}
