// ReSharper disable InconsistentNaming

using SharpnYNAB.Schema.Types;

namespace SharpnYNAB.Schema.Budget
{
    public class AccountMapping:Entity
    {
        public Date date_sequence { get; set; }
        public Account entities_account { get; set; }
        public string hash { get; set; }
        public string fid { get; set; }
        public string salt { get; set; }
        public string shortened_account_id { get; set; }
        public string should_flip_payees_memos { get; set; }
        public string should_import_memos { get; set; }
        public string skip_import { get; set; }
    }
}