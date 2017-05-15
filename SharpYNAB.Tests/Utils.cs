using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace SharpYNAB.Tests
{
    class Utils
    {
        public static Args GetTestArgs()
        {
            try
            {
                return JsonConvert.DeserializeObject<Args>(File.ReadAllText("ynab.conf"));
            }
            catch (FileNotFoundException)
            {
                return new Args
                {
                    Email = Environment.GetEnvironmentVariable("YNAB_EMAIL"),
                    Password = Environment.GetEnvironmentVariable("YNAB_PASSWORD"),
                    BudgetName = Environment.GetEnvironmentVariable("YNAB_BUDGETNAME")
                };
            }
        }
    }
}
