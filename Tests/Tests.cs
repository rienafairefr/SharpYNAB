using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using SharpnYNAB;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        public class Args
        {
            public string email { get; set; }
            public string password { get; set; }
        }
        [Test]
        public void Test1()
        {
            Args args;
            using (var file = File.OpenText(("ynab.conf")))
            {
                var serializer = new JsonSerializer();
                args = (Args)serializer.Deserialize(file, typeof(Args));
            }
            var connection = new Connection(args.email, args.password);
        }
    }
}
