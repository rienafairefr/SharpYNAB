using System;
using SharpnYNAB.Schema.Types;
// ReSharper disable InconsistentNaming

namespace SharpnYNAB.Schema.Budget
{
    public class Account : Entity
    {
        public string account_name { get; set; }
        public AccountType account_type { get; set; }
        public bool hidden { get; set; }
        public string last_entered_check_number { get; set; }
        public Date last_reconciled_balance { get; set; }
        public Date last_reconciled_date { get; set; }
        public string note { get; set; }
        public int sortable_index { get; set; }
        public bool on_budget { get; set; } = true;

        public bool direct_connect_enabled { get; set; }
        public Guid? direct_connect_account_id { get; set; }
        public Guid? direct_connect_institution_id { get; set; }
        public Date direct_connect_last_imported_at { get; set; }
        public string direct_connect_last_error_code { get; set; }
        public string direct_import_status { get; set; }
        public string direct_import_institution_name { get; set; }
        public string direct_import_account_name { get; set; }
    }

    public enum AccountType
    {
        undef, Checking, Savings, CreditCard, Cash,
        LineOfCredit, PayPal, MerchantAccount, InvestmentAccount,
        Mortgage, OtherAsset, OtherLiability
    }
}