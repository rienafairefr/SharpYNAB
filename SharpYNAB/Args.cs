using SharpYNAB.Contracts;

namespace SharpYNAB
{
    public class Args
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string BudgetName { get; set; }
        public IConnection Connection { get; set; }
    }
}