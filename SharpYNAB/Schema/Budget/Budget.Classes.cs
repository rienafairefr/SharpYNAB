using System;
using Newtonsoft.Json;
using SharpYNAB.Schema.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable ExplicitCallerInfoArgument

namespace SharpYNAB.Schema.Budget
{
    public class Account : Entity
    {
        [JsonProperty("sortable_index")]
        public int SortableIndex { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        [JsonProperty("on_budget")]
        public bool OnBudget { get => _onbudget ; set{ _onbudget = value;OnPropertyChanged();} } 
        [JsonProperty("note")]
        public string Note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        [JsonProperty("last_reconciled_date")]
        [NotMapped]
        public Date LastReconciledDate { get => _lastreconcileddate ; set{ _lastreconcileddate = value;OnPropertyChanged();} } 
            public DateTime LastReconciledDateValue { get => LastReconciledDate.Value ; set{ LastReconciledDate.Value = value;OnPropertyChanged(nameof(LastReconciledDate));} } 
        [JsonProperty("last_reconciled_balance")]
        [NotMapped]
        public Date LastReconciledBalance { get => _lastreconciledbalance ; set{ _lastreconciledbalance = value;OnPropertyChanged();} } 
            public DateTime LastReconciledBalanceValue { get => LastReconciledBalance.Value ; set{ LastReconciledBalance.Value = value;OnPropertyChanged(nameof(LastReconciledBalance));} } 
        [JsonProperty("last_entered_check_number")]
        public string LastEnteredCheckNumber { get => _lastenteredchecknumber ; set{ _lastenteredchecknumber = value;OnPropertyChanged();} } 
        [JsonProperty("hidden")]
        public bool Hidden { get => _hidden ; set{ _hidden = value;OnPropertyChanged();} } 
        [JsonProperty("direct_import_account_name")]
        public string DirectImportAccountName { get => _directimportaccountname ; set{ _directimportaccountname = value;OnPropertyChanged();} } 
        [JsonProperty("direct_import_institution_name")]
        public string DirectImportInstitutionName { get => _directimportinstitutionname ; set{ _directimportinstitutionname = value;OnPropertyChanged();} } 
        [JsonProperty("direct_import_status")]
        public string DirectImportStatus { get => _directimportstatus ; set{ _directimportstatus = value;OnPropertyChanged();} } 
        [JsonProperty("direct_connect_last_error_code")]
        public string DirectConnectLastErrorCode { get => _directconnectlasterrorcode ; set{ _directconnectlasterrorcode = value;OnPropertyChanged();} } 
        [JsonProperty("direct_connect_last_imported_at")]
        [NotMapped]
        public Date DirectConnectLastImportedAt { get => _directconnectlastimportedat ; set{ _directconnectlastimportedat = value;OnPropertyChanged();} } 
            public DateTime DirectConnectLastImportedAtValue { get => DirectConnectLastImportedAt.Value ; set{ DirectConnectLastImportedAt.Value = value;OnPropertyChanged(nameof(DirectConnectLastImportedAt));} } 
        [JsonProperty("direct_connect_institution_id")]
        public Guid? DirectConnectInstitutionId { get => _directconnectinstitutionid ; set{ _directconnectinstitutionid = value;OnPropertyChanged();} } 
        [JsonProperty("direct_connect_account_id")]
        public Guid? DirectConnectAccountId { get => _directconnectaccountid ; set{ _directconnectaccountid = value;OnPropertyChanged();} } 
        [JsonProperty("direct_connect_enabled")]
        public bool DirectConnectEnabled { get => _directconnectenabled ; set{ _directconnectenabled = value;OnPropertyChanged();} } 
        [JsonProperty("account_type")]
        public AccountType AccountType { get => _accounttype ; set{ _accounttype = value;OnPropertyChanged();} } 
        [JsonProperty("account_name")]
        public string AccountName { get => _accountname ; set{ _accountname = value;OnPropertyChanged();} } 
        [JsonProperty("AccountCalculations")]
        public List<AccountCalculation> AccountCalculations { get => _accountcalculations ; set{ _accountcalculations = value;OnPropertyChanged();} } 

#region fields
        private string _accountname  ;

        private List<AccountCalculation> _accountcalculations  ;

        private AccountType _accounttype  ;

        private bool _hidden  ;

        private string _lastenteredchecknumber  ;

        private Date _lastreconciledbalance  = new Date();

        private Date _lastreconcileddate  = new Date();

        private string _note  ;

        private int _sortableindex  ;

        private bool _onbudget  ;

        private bool _directconnectenabled  ;

        private Guid? _directconnectaccountid  ;

        private Guid? _directconnectinstitutionid  ;

        private Date _directconnectlastimportedat  = new Date();

        private string _directconnectlasterrorcode  ;

        private string _directimportstatus  ;

        private string _directimportinstitutionname  ;

        private string _directimportaccountname  ;

#endregion
    }
    public class AccountCalculation : Entity
    {
        [JsonProperty("warning_count")]
        public string WarningCount { get => _warningcount ; set{ _warningcount = value;OnPropertyChanged();} } 
        [JsonProperty("uncleared_balance")]
        [NotMapped]
        public Amount UnclearedBalance { get => _unclearedbalance ; set{ _unclearedbalance = value;OnPropertyChanged();} } 
            public decimal UnclearedBalanceValue { get => UnclearedBalance.Value ; set{ UnclearedBalance.Value = value;OnPropertyChanged(nameof(UnclearedBalance));} } 
        [JsonProperty("transaction_count")]
        public string TransactionCount { get => _transactioncount ; set{ _transactioncount = value;OnPropertyChanged();} } 
        [JsonProperty("info_count")]
        public string InfoCount { get => _infocount ; set{ _infocount = value;OnPropertyChanged();} } 
        [JsonProperty("entities_account_id")]
        [ForeignKey(nameof(EntitiesAccount))]
        public Guid EntitiesAccountId { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account EntitiesAccount { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        [JsonProperty("error_count")]
        public string ErrorCount { get => _errorcount ; set{ _errorcount = value;OnPropertyChanged();} } 
        [JsonProperty("cleared_balance")]
        [NotMapped]
        public Amount ClearedBalance { get => _clearedbalance ; set{ _clearedbalance = value;OnPropertyChanged();} } 
            public decimal ClearedBalanceValue { get => ClearedBalance.Value ; set{ ClearedBalance.Value = value;OnPropertyChanged(nameof(ClearedBalance));} } 

#region fields
        private Amount _clearedbalance  = new Amount();

        private string _errorcount  ;

        private string _infocount  ;

        private string _transactioncount  ;

        private Amount _unclearedbalance  = new Amount();

        private string _warningcount  ;

        private Account _entitiesaccount  ;

        private Guid _entitiesaccountid  ;

#endregion
    }
    public class AccountMapping : Entity
    {
        [JsonProperty("skip_import")]
        public string SkipImport { get => _skipimport ; set{ _skipimport = value;OnPropertyChanged();} } 
        [JsonProperty("should_import_memos")]
        public string ShouldImportMemos { get => _shouldimportmemos ; set{ _shouldimportmemos = value;OnPropertyChanged();} } 
        [JsonProperty("should_flip_payees_memos")]
        public string ShouldFlipPayeesMemos { get => _shouldflippayeesmemos ; set{ _shouldflippayeesmemos = value;OnPropertyChanged();} } 
        [JsonProperty("shortened_account_id")]
        public string ShortenedAccountId { get => _shortenedaccountid ; set{ _shortenedaccountid = value;OnPropertyChanged();} } 
        [JsonProperty("salt")]
        public string Salt { get => _salt ; set{ _salt = value;OnPropertyChanged();} } 
        [JsonProperty("hash")]
        public string Hash { get => _hash ; set{ _hash = value;OnPropertyChanged();} } 
        [JsonProperty("fid")]
        public string Fid { get => _fid ; set{ _fid = value;OnPropertyChanged();} } 
        [JsonProperty("entities_account_id")]
        public Guid EntitiesAccountId { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account EntitiesAccount { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        [JsonProperty("date_sequence")]
        [NotMapped]
        public Date DateSequence { get => _datesequence ; set{ _datesequence = value;OnPropertyChanged();} } 
            public DateTime DateSequenceValue { get => DateSequence.Value ; set{ DateSequence.Value = value;OnPropertyChanged(nameof(DateSequence));} } 

#region fields
        private Date _datesequence  = new Date();

        private string _hash  ;

        private string _fid  ;

        private string _salt  ;

        private string _shortenedaccountid  ;

        private string _shouldflippayeesmemos  ;

        private string _shouldimportmemos  ;

        private string _skipimport  ;

        private Account _entitiesaccount  ;

        private Guid _entitiesaccountid  ;

#endregion
    }
    public class PayeeRenameCondition : Entity
    {
        [JsonProperty("operand")]
        public string Operand { get => _operand ; set{ _operand = value;OnPropertyChanged();} } 
        [JsonProperty("operator")]
        public string Operator { get => _operator ; set{ _operator = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Payee EntitiesPayee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        [JsonProperty("entities_payee_id")]
        [ForeignKey(nameof(EntitiesPayee))]
        public Guid EntitiesPayeeId { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 

#region fields
        private Guid _entitiespayeeid  ;

        private Payee _entitiespayee  ;

        private string _operator  ;

        private string _operand  ;

#endregion
    }
    public class MasterCategory : Entity
    {
        [JsonProperty("sortable_index")]
        public int SortableIndex { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        [JsonProperty("note")]
        public string Note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        [JsonProperty("name")]
        public string Name { get => _name ; set{ _name = value;OnPropertyChanged();} } 
        [JsonProperty("is_hidden")]
        public bool? IsHidden { get => _ishidden ; set{ _ishidden = value;OnPropertyChanged();} } 
        [JsonProperty("internal_name")]
        public string InternalName { get => _internalname ; set{ _internalname = value;OnPropertyChanged();} } 
        [JsonProperty("deletable")]
        public bool Deletable { get => _deletable ; set{ _deletable = value;OnPropertyChanged();} } 

#region fields
        private bool _deletable  ;

        private string _internalname  ;

        private bool? _ishidden  ;

        private string _name  ;

        private string _note  ;

        private int _sortableindex  ;

#endregion
    }
    public class MonthlyAccountCalculation : Entity
    {
        [JsonProperty("warning_count")]
        public string WarningCount { get => _warningcount ; set{ _warningcount = value;OnPropertyChanged();} } 
        [JsonProperty("uncleared_balance")]
        [NotMapped]
        public Amount UnclearedBalance { get => _unclearedbalance ; set{ _unclearedbalance = value;OnPropertyChanged();} } 
            public decimal UnclearedBalanceValue { get => UnclearedBalance.Value ; set{ UnclearedBalance.Value = value;OnPropertyChanged(nameof(UnclearedBalance));} } 
        [JsonProperty("transaction_count")]
        public string TransactionCount { get => _transactioncount ; set{ _transactioncount = value;OnPropertyChanged();} } 
        [JsonProperty("rolling_balance")]
        [NotMapped]
        public Amount RollingBalance { get => _rollingbalance ; set{ _rollingbalance = value;OnPropertyChanged();} } 
            public decimal RollingBalanceValue { get => RollingBalance.Value ; set{ RollingBalance.Value = value;OnPropertyChanged(nameof(RollingBalance));} } 
        [JsonProperty("month")]
        public string Month { get => _month ; set{ _month = value;OnPropertyChanged();} } 
        [JsonProperty("info_count")]
        public string InfoCount { get => _infocount ; set{ _infocount = value;OnPropertyChanged();} } 
        [JsonProperty("error_count")]
        public string ErrorCount { get => _errorcount ; set{ _errorcount = value;OnPropertyChanged();} } 
        [JsonProperty("entities_account_id")]
        [ForeignKey(nameof(EntitiesAccount))]
        public Guid EntitiesAccountId { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account EntitiesAccount { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        [JsonProperty("cleared_balance")]
        [NotMapped]
        public Amount ClearedBalance { get => _clearedbalance ; set{ _clearedbalance = value;OnPropertyChanged();} } 
            public decimal ClearedBalanceValue { get => ClearedBalance.Value ; set{ ClearedBalance.Value = value;OnPropertyChanged(nameof(ClearedBalance));} } 

#region fields
        private Amount _clearedbalance  = new Amount();

        private Account _entitiesaccount  ;

        private Guid _entitiesaccountid  ;

        private string _errorcount  ;

        private string _infocount  ;

        private string _month  ;

        private string _transactioncount  ;

        private Amount _unclearedbalance  = new Amount();

        private string _warningcount  ;

        private Amount _rollingbalance  = new Amount();

#endregion
    }
    public class MonthlyBudget : Entity
    {
        [JsonProperty("note")]
        public string Note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        [JsonProperty("month")]
        [NotMapped]
        public Date Month { get => _month ; set{ _month = value;OnPropertyChanged();} } 
            public DateTime MonthValue { get => Month.Value ; set{ Month.Value = value;OnPropertyChanged(nameof(Month));} } 

#region fields
        private Date _month  = new Date();

        private string _note  ;

#endregion
    }
    public class MonthlyBudgetCalculation : Entity
    {
        [JsonProperty("uncategorized_credit_outflows")]
        [NotMapped]
        public Amount UncategorizedCreditOutflows { get => _uncategorizedcreditoutflows ; set{ _uncategorizedcreditoutflows = value;OnPropertyChanged();} } 
            public decimal UncategorizedCreditOutflowsValue { get => UncategorizedCreditOutflows.Value ; set{ UncategorizedCreditOutflows.Value = value;OnPropertyChanged(nameof(UncategorizedCreditOutflows));} } 
        [JsonProperty("uncategorized_cash_outflows")]
        [NotMapped]
        public Amount UncategorizedCashOutflows { get => _uncategorizedcashoutflows ; set{ _uncategorizedcashoutflows = value;OnPropertyChanged();} } 
            public decimal UncategorizedCashOutflowsValue { get => UncategorizedCashOutflows.Value ; set{ UncategorizedCashOutflows.Value = value;OnPropertyChanged(nameof(UncategorizedCashOutflows));} } 
        [JsonProperty("uncategorized_balance")]
        [NotMapped]
        public Amount UncategorizedBalance { get => _uncategorizedbalance ; set{ _uncategorizedbalance = value;OnPropertyChanged();} } 
            public decimal UncategorizedBalanceValue { get => UncategorizedBalance.Value ; set{ UncategorizedBalance.Value = value;OnPropertyChanged(nameof(UncategorizedBalance));} } 
        [JsonProperty("previous_income")]
        [NotMapped]
        public Amount PreviousIncome { get => _previousincome ; set{ _previousincome = value;OnPropertyChanged();} } 
            public decimal PreviousIncomeValue { get => PreviousIncome.Value ; set{ PreviousIncome.Value = value;OnPropertyChanged(nameof(PreviousIncome));} } 
        [JsonProperty("over_spent")]
        [NotMapped]
        public Amount OverSpent { get => _overspent ; set{ _overspent = value;OnPropertyChanged();} } 
            public decimal OverSpentValue { get => OverSpent.Value ; set{ OverSpent.Value = value;OnPropertyChanged(nameof(OverSpent));} } 
        [JsonProperty("immediate_income")]
        [NotMapped]
        public Amount ImmediateIncome { get => _immediateincome ; set{ _immediateincome = value;OnPropertyChanged();} } 
            public decimal ImmediateIncomeValue { get => ImmediateIncome.Value ; set{ ImmediateIncome.Value = value;OnPropertyChanged(nameof(ImmediateIncome));} } 
        [JsonProperty("hidden_credit_outflows")]
        [NotMapped]
        public Amount HiddenCreditOutflows { get => _hiddencreditoutflows ; set{ _hiddencreditoutflows = value;OnPropertyChanged();} } 
            public decimal HiddenCreditOutflowsValue { get => HiddenCreditOutflows.Value ; set{ HiddenCreditOutflows.Value = value;OnPropertyChanged(nameof(HiddenCreditOutflows));} } 
        [JsonProperty("hidden_cash_outflows")]
        [NotMapped]
        public Amount HiddenCashOutflows { get => _hiddencashoutflows ; set{ _hiddencashoutflows = value;OnPropertyChanged();} } 
            public decimal HiddenCashOutflowsValue { get => HiddenCashOutflows.Value ; set{ HiddenCashOutflows.Value = value;OnPropertyChanged(nameof(HiddenCashOutflows));} } 
        [JsonProperty("hidden_budgeted")]
        [NotMapped]
        public Amount HiddenBudgeted { get => _hiddenbudgeted ; set{ _hiddenbudgeted = value;OnPropertyChanged();} } 
            public decimal HiddenBudgetedValue { get => HiddenBudgeted.Value ; set{ HiddenBudgeted.Value = value;OnPropertyChanged(nameof(HiddenBudgeted));} } 
        [JsonProperty("hidden_balance")]
        [NotMapped]
        public Amount HiddenBalance { get => _hiddenbalance ; set{ _hiddenbalance = value;OnPropertyChanged();} } 
            public decimal HiddenBalanceValue { get => HiddenBalance.Value ; set{ HiddenBalance.Value = value;OnPropertyChanged(nameof(HiddenBalance));} } 
        [JsonProperty("entities_monthly_budget_id")]
        [ForeignKey(nameof(EntitiesMonthlyBudget))]
        public Guid EntitiesMonthlyBudgetId { get => _entitiesmonthlybudgetid ; set{ _entitiesmonthlybudgetid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public MonthlyBudget EntitiesMonthlyBudget { get => _entitiesmonthlybudget ; set{ _entitiesmonthlybudget = value;OnPropertyChanged();} } 
        [JsonProperty("deferred_income")]
        [NotMapped]
        public Amount DeferredIncome { get => _deferredincome ; set{ _deferredincome = value;OnPropertyChanged();} } 
            public decimal DeferredIncomeValue { get => DeferredIncome.Value ; set{ DeferredIncome.Value = value;OnPropertyChanged(nameof(DeferredIncome));} } 
        [JsonProperty("credit_outflows")]
        [NotMapped]
        public Amount CreditOutflows { get => _creditoutflows ; set{ _creditoutflows = value;OnPropertyChanged();} } 
            public decimal CreditOutflowsValue { get => CreditOutflows.Value ; set{ CreditOutflows.Value = value;OnPropertyChanged(nameof(CreditOutflows));} } 
        [JsonProperty("cash_outflows")]
        [NotMapped]
        public Amount CashOutflows { get => _cashoutflows ; set{ _cashoutflows = value;OnPropertyChanged();} } 
            public decimal CashOutflowsValue { get => CashOutflows.Value ; set{ CashOutflows.Value = value;OnPropertyChanged(nameof(CashOutflows));} } 
        [JsonProperty("calculation_notes")]
        public string CalculationNotes { get => _calculationnotes ; set{ _calculationnotes = value;OnPropertyChanged();} } 
        [JsonProperty("budgeted")]
        public string Budgeted { get => _budgeted ; set{ _budgeted = value;OnPropertyChanged();} } 
        [JsonProperty("balance")]
        public string Balance { get => _balance ; set{ _balance = value;OnPropertyChanged();} } 
        [JsonProperty("available_to_budget")]
        public string AvailableToBudget { get => _availabletobudget ; set{ _availabletobudget = value;OnPropertyChanged();} } 
        [JsonProperty("age_of_money")]
        public string AgeOfMoney { get => _ageofmoney ; set{ _ageofmoney = value;OnPropertyChanged();} } 
        [JsonProperty("additional_to_be_budgeted")]
        [NotMapped]
        public Amount AdditionalToBeBudgeted { get => _additionaltobebudgeted ; set{ _additionaltobebudgeted = value;OnPropertyChanged();} } 
            public decimal AdditionalToBeBudgetedValue { get => AdditionalToBeBudgeted.Value ; set{ AdditionalToBeBudgeted.Value = value;OnPropertyChanged(nameof(AdditionalToBeBudgeted));} } 

#region fields
        private Amount _additionaltobebudgeted  = new Amount();

        private string _ageofmoney  ;

        private string _availabletobudget  ;

        private string _balance  ;

        private string _budgeted  ;

        private string _calculationnotes  ;

        private Amount _cashoutflows  = new Amount();

        private Amount _creditoutflows  = new Amount();

        private Amount _deferredincome  = new Amount();

        private MonthlyBudget _entitiesmonthlybudget  ;

        private Guid _entitiesmonthlybudgetid  ;

        private Amount _hiddenbalance  = new Amount();

        private Amount _hiddenbudgeted  = new Amount();

        private Amount _hiddencashoutflows  = new Amount();

        private Amount _hiddencreditoutflows  = new Amount();

        private Amount _immediateincome  = new Amount();

        private Amount _overspent  = new Amount();

        private Amount _previousincome  = new Amount();

        private Amount _uncategorizedbalance  = new Amount();

        private Amount _uncategorizedcashoutflows  = new Amount();

        private Amount _uncategorizedcreditoutflows  = new Amount();

#endregion
    }
    public class MonthlySubcategoryBudget : Entity
    {
        [JsonProperty("overspending_handling")]
        public string OverspendingHandling { get => _overspendinghandling ; set{ _overspendinghandling = value;OnPropertyChanged();} } 
        [JsonProperty("note")]
        public string Note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        [JsonProperty("entities_subcategory_id")]
        [ForeignKey(nameof(EntitiesSubcategory))]
        public Guid EntitiesSubcategoryId { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Subcategory EntitiesSubcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        [JsonProperty("entities_monthly_budget_id")]
        [ForeignKey(nameof(EntitiesMonthlyBudget))]
        public Guid EntitiesMonthlyBudgetId { get => _entitiesmonthlybudgetid ; set{ _entitiesmonthlybudgetid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public MonthlyBudget EntitiesMonthlyBudget { get => _entitiesmonthlybudget ; set{ _entitiesmonthlybudget = value;OnPropertyChanged();} } 
        [JsonProperty("budgeted")]
        [NotMapped]
        public Amount Budgeted { get => _budgeted ; set{ _budgeted = value;OnPropertyChanged();} } 
            public decimal BudgetedValue { get => Budgeted.Value ; set{ Budgeted.Value = value;OnPropertyChanged(nameof(Budgeted));} } 

#region fields
        private Amount _budgeted  = new Amount();

        private MonthlyBudget _entitiesmonthlybudget  ;

        private Guid _entitiesmonthlybudgetid  ;

        private Subcategory _entitiessubcategory  ;

        private Guid _entitiessubcategoryid  ;

        private string _note  ;

        private string _overspendinghandling  ;

#endregion
    }
    public class Setting : Entity
    {
        [JsonProperty("setting_value")]
        public string SettingValue { get => _settingvalue ; set{ _settingvalue = value;OnPropertyChanged();} } 
        [JsonProperty("setting_name")]
        public string SettingName { get => _settingname ; set{ _settingname = value;OnPropertyChanged();} } 

#region fields
        private string _settingname  ;

        private string _settingvalue  ;

#endregion
    }
    public class UpcomingInstance : Entity
    {
        [JsonProperty("scheduled_transaction_id")]
        [ForeignKey(nameof(ScheduledTransaction))]
        public Guid ScheduledTransactionId { get => _scheduledtransactionid ; set{ _scheduledtransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public ScheduledTransaction ScheduledTransaction { get => _scheduledtransaction ; set{ _scheduledtransaction = value;OnPropertyChanged();} } 

#region fields
        private ScheduledTransaction _scheduledtransaction  ;

        private Guid _scheduledtransactionid  ;

#endregion
    }
    public class Transaction : Entity
    {
        [JsonProperty("ynab_id")]
        public string YnabId { get => _ynabid ; set{ _ynabid = value;OnPropertyChanged();} } 
        [JsonProperty("transfer_transaction_id")]
        [ForeignKey(nameof(TransferTransaction))]
        public Guid? TransferTransactionId { get => _transfertransactionid ; set{ _transfertransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Transaction TransferTransaction { get => _transfertransaction ; set{ _transfertransaction = value;OnPropertyChanged();} } 
        [JsonProperty("transfer_subtransaction_id")]
        [ForeignKey(nameof(TransferSubtransaction))]
        public Guid? TransferSubtransactionId { get => _transfersubtransactionid ; set{ _transfersubtransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Subtransaction TransferSubtransaction { get => _transfersubtransaction ; set{ _transfersubtransaction = value;OnPropertyChanged();} } 
        [JsonProperty("transfer_account_id")]
        [ForeignKey(nameof(TransferAccount))]
        public Guid? TransferAccountId { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account TransferAccount { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        [JsonProperty("subcategory_credit_amount_preceding")]
        [NotMapped]
        public Amount SubcategoryCreditAmountPreceding { get => _subcategorycreditamountpreceding ; set{ _subcategorycreditamountpreceding = value;OnPropertyChanged();} } 
            public decimal SubcategoryCreditAmountPrecedingValue { get => SubcategoryCreditAmountPreceding.Value ; set{ SubcategoryCreditAmountPreceding.Value = value;OnPropertyChanged(nameof(SubcategoryCreditAmountPreceding));} } 
        [JsonProperty("source")]
        public string Source { get => _source ; set{ _source = value;OnPropertyChanged();} } 
        [JsonProperty("subtransactions")]
        public List<Subtransaction> Subtransactions { get => _subtransactions ; set{ _subtransactions = value;OnPropertyChanged();} } 
        [JsonProperty("matched_transaction_id")]
        [ForeignKey(nameof(MatchedTransaction))]
        public Guid? MatchedTransactionId { get => _matchedtransactionid ; set{ _matchedtransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Transaction MatchedTransaction { get => _matchedtransaction ; set{ _matchedtransaction = value;OnPropertyChanged();} } 
        [JsonProperty("memo")]
        public string Memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        [JsonProperty("imported_payee")]
        public string ImportedPayee { get => _importedpayee ; set{ _importedpayee = value;OnPropertyChanged();} } 
        [JsonProperty("imported_date")]
        [NotMapped]
        public Date ImportedDate { get => _importeddate ; set{ _importeddate = value;OnPropertyChanged();} } 
            public DateTime ImportedDateValue { get => ImportedDate.Value ; set{ ImportedDate.Value = value;OnPropertyChanged(nameof(ImportedDate));} } 
        [JsonProperty("flag")]
        public string Flag { get => _flag ; set{ _flag = value;OnPropertyChanged();} } 
        [JsonProperty("entities_scheduled_transaction_id")]
        [ForeignKey(nameof(EntitiesScheduledTransaction))]
        public Guid? EntitiesScheduledTransactionId { get => _entitiesscheduledtransactionid ; set{ _entitiesscheduledtransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public ScheduledTransaction EntitiesScheduledTransaction { get => _entitiesscheduledtransaction ; set{ _entitiesscheduledtransaction = value;OnPropertyChanged();} } 
        [JsonProperty("entities_subcategory_id")]
        [ForeignKey(nameof(EntitiesSubcategory))]
        public Guid EntitiesSubcategoryId { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Subcategory EntitiesSubcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        [JsonProperty("entities_payee_id")]
        [ForeignKey(nameof(EntitiesPayee))]
        public Guid EntitiesPayeeId { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Payee EntitiesPayee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        [JsonProperty("entities_account_id")]
        [ForeignKey(nameof(EntitiesAccount))]
        public Guid EntitiesAccountId { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account EntitiesAccount { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        [JsonProperty("date_entered_from_schedule")]
        [NotMapped]
        public Date DateEnteredFromSchedule { get => _dateenteredfromschedule ; set{ _dateenteredfromschedule = value;OnPropertyChanged();} } 
            public DateTime DateEnteredFromScheduleValue { get => DateEnteredFromSchedule.Value ; set{ DateEnteredFromSchedule.Value = value;OnPropertyChanged(nameof(DateEnteredFromSchedule));} } 
        [JsonProperty("date")]
        [NotMapped]
        public Date Date { get => _date ; set{ _date = value;OnPropertyChanged();} } 
            public DateTime DateValue { get => Date.Value ; set{ Date.Value = value;OnPropertyChanged(nameof(Date));} } 
        [JsonProperty("credit_amount_adjusted")]
        public bool? CreditAmountAdjusted { get => _creditamountadjusted ; set{ _creditamountadjusted = value;OnPropertyChanged();} } 
        [JsonProperty("credit_amount")]
        [NotMapped]
        public Amount CreditAmount { get => _creditamount ; set{ _creditamount = value;OnPropertyChanged();} } 
            public decimal CreditAmountValue { get => CreditAmount.Value ; set{ CreditAmount.Value = value;OnPropertyChanged(nameof(CreditAmount));} } 
        [JsonProperty("cleared")]
        public string Cleared { get => _cleared ; set{ _cleared = value;OnPropertyChanged();} } 
        [JsonProperty("check_number")]
        public string CheckNumber { get => _checknumber ; set{ _checknumber = value;OnPropertyChanged();} } 
        [JsonProperty("cash_amount")]
        [NotMapped]
        public Amount CashAmount { get => _cashamount ; set{ _cashamount = value;OnPropertyChanged();} } 
            public decimal CashAmountValue { get => CashAmount.Value ; set{ CashAmount.Value = value;OnPropertyChanged(nameof(CashAmount));} } 
        [JsonProperty("amount")]
        [NotMapped]
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
            public decimal AmountValue { get => Amount.Value ; set{ Amount.Value = value;OnPropertyChanged(nameof(Amount));} } 
        [JsonProperty("accepted")]
        public bool Accepted { get => _accepted ; set{ _accepted = value;OnPropertyChanged();} } 

#region fields
        private string _ynabid  ;

        private List<Subtransaction> _subtransactions  ;

        private string _memo  ;

        private string _source  ;

        private Amount _subcategorycreditamountpreceding  = new Amount();

        private bool _accepted  ;

        private Amount _amount  = new Amount();

        private Amount _cashamount  = new Amount();

        private string _checknumber  ;

        private string _cleared  ;

        private Amount _creditamount  = new Amount();

        private bool? _creditamountadjusted  ;

        private Date _date  = new Date();

        private Date _dateenteredfromschedule  = new Date();

        private string _flag  ;

        private Date _importeddate  = new Date();

        private string _importedpayee  ;

        private Account _entitiesaccount  ;

        private Guid _entitiesaccountid  ;

        private Payee _entitiespayee  ;

        private Guid _entitiespayeeid  ;

        private Subcategory _entitiessubcategory  ;

        private Guid _entitiessubcategoryid  ;

        private ScheduledTransaction _entitiesscheduledtransaction  ;

        private Guid? _entitiesscheduledtransactionid  ;

        private Transaction _matchedtransaction  ;

        private Guid? _matchedtransactionid  ;

        private Account _transferaccount  ;

        private Guid? _transferaccountid  ;

        private Subtransaction _transfersubtransaction  ;

        private Guid? _transfersubtransactionid  ;

        private Transaction _transfertransaction  ;

        private Guid? _transfertransactionid  ;

#endregion
    }
    public class Subtransaction : Entity
    {
        [JsonProperty("transfer_transaction_id")]
        [ForeignKey(nameof(TransferTransaction))]
        public Guid TransferTransactionId { get => _transfertransactionid ; set{ _transfertransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Transaction TransferTransaction { get => _transfertransaction ; set{ _transfertransaction = value;OnPropertyChanged();} } 
        [JsonProperty("transfer_account_id")]
        [ForeignKey(nameof(TransferAccount))]
        public Guid TransferAccountId { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account TransferAccount { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        [JsonProperty("subcategory_credit_amount_preceding")]
        public int SubcategoryCreditAmountPreceding { get => _subcategorycreditamountpreceding ; set{ _subcategorycreditamountpreceding = value;OnPropertyChanged();} } 
        [JsonProperty("sortable_index")]
        public int SortableIndex { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        [JsonProperty("memo")]
        public string Memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        [JsonProperty("heck_number")]
        public string HeckNumber { get => _hecknumber ; set{ _hecknumber = value;OnPropertyChanged();} } 
        [JsonProperty("entities_transaction_id")]
        [ForeignKey(nameof(EntitiesTransaction))]
        public Guid EntitiesTransactionId { get => _entitiestransactionid ; set{ _entitiestransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Transaction EntitiesTransaction { get => _entitiestransaction ; set{ _entitiestransaction = value;OnPropertyChanged();} } 
        [JsonProperty("entities_subcategory_id")]
        [ForeignKey(nameof(EntitiesSubcategory))]
        public Guid EntitiesSubcategoryId { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Subcategory EntitiesSubcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        [JsonProperty("entities_payee_id")]
        [ForeignKey(nameof(EntitiesPayee))]
        public Guid EntitiesPayeeId { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Payee EntitiesPayee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        [JsonProperty("credit_amount")]
        [NotMapped]
        public Amount CreditAmount { get => _creditamount ; set{ _creditamount = value;OnPropertyChanged();} } 
            public decimal CreditAmountValue { get => CreditAmount.Value ; set{ CreditAmount.Value = value;OnPropertyChanged(nameof(CreditAmount));} } 
        [JsonProperty("cash_amount")]
        [NotMapped]
        public Amount CashAmount { get => _cashamount ; set{ _cashamount = value;OnPropertyChanged();} } 
            public decimal CashAmountValue { get => CashAmount.Value ; set{ CashAmount.Value = value;OnPropertyChanged(nameof(CashAmount));} } 
        [JsonProperty("amount")]
        [NotMapped]
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
            public decimal AmountValue { get => Amount.Value ; set{ Amount.Value = value;OnPropertyChanged(nameof(Amount));} } 

#region fields
        private Amount _amount  = new Amount();

        private Amount _cashamount  = new Amount();

        private string _hecknumber  ;

        private Amount _creditamount  = new Amount();

        private string _memo  ;

        private int _sortableindex  ;

        private int _subcategorycreditamountpreceding  ;

        private Payee _entitiespayee  ;

        private Guid _entitiespayeeid  ;

        private Subcategory _entitiessubcategory  ;

        private Guid _entitiessubcategoryid  ;

        private Transaction _entitiestransaction  ;

        private Guid _entitiestransactionid  ;

        private Account _transferaccount  ;

        private Guid _transferaccountid  ;

        private Transaction _transfertransaction  ;

        private Guid _transfertransactionid  ;

#endregion
    }
    public class Subcategory : Entity
    {
        [JsonProperty("type")]
        public string Type { get => _type ; set{ _type = value;OnPropertyChanged();} } 
        [JsonProperty("target_balance_month")]
        public string TargetBalanceMonth { get => _targetbalancemonth ; set{ _targetbalancemonth = value;OnPropertyChanged();} } 
        [JsonProperty("target_balance")]
        [NotMapped]
        public Amount TargetBalance { get => _targetbalance ; set{ _targetbalance = value;OnPropertyChanged();} } 
            public decimal TargetBalanceValue { get => TargetBalance.Value ; set{ TargetBalance.Value = value;OnPropertyChanged(nameof(TargetBalance));} } 
        [JsonProperty("sortable_index")]
        public int SortableIndex { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        [JsonProperty("note")]
        public string Note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        [JsonProperty("name")]
        public string Name { get => _name ; set{ _name = value;OnPropertyChanged();} } 
        [JsonProperty("monthly_funding")]
        public string MonthlyFunding { get => _monthlyfunding ; set{ _monthlyfunding = value;OnPropertyChanged();} } 
        [JsonProperty("is_hidden")]
        public bool? IsHidden { get => _ishidden ; set{ _ishidden = value;OnPropertyChanged();} } 
        [JsonProperty("internal_name")]
        public string InternalName { get => _internalname ; set{ _internalname = value;OnPropertyChanged();} } 
        [JsonProperty("goal_type")]
        public string GoalType { get => _goaltype ; set{ _goaltype = value;OnPropertyChanged();} } 
        [JsonProperty("goal_creation_month")]
        public string GoalCreationMonth { get => _goalcreationmonth ; set{ _goalcreationmonth = value;OnPropertyChanged();} } 
        [JsonProperty("entities_master_category_id")]
        [ForeignKey(nameof(EntitiesMasterCategory))]
        public Guid EntitiesMasterCategoryId { get => _entitiesmastercategoryid ; set{ _entitiesmastercategoryid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public MasterCategory EntitiesMasterCategory { get => _entitiesmastercategory ; set{ _entitiesmastercategory = value;OnPropertyChanged();} } 
        [JsonProperty("entities_account_id")]
        [ForeignKey(nameof(EntitiesAccount))]
        public Guid? EntitiesAccountId { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account EntitiesAccount { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        [JsonProperty("MonthlySubcategoryBudget")]
        public MonthlySubcategoryBudget MonthlySubcategoryBudget { get => _monthlysubcategorybudget ; set{ _monthlysubcategorybudget = value;OnPropertyChanged();} } 

#region fields
        private MonthlySubcategoryBudget _monthlysubcategorybudget  ;

        private string _goalcreationmonth  ;

        private string _goaltype  ;

        private string _internalname  ;

        private bool? _ishidden  = false ;

        private string _monthlyfunding  ;

        private string _name  ;

        private string _note  ;

        private int _sortableindex  ;

        private Amount _targetbalance  = new Amount();

        private string _targetbalancemonth  ;

        private string _type  ;

        private Account _entitiesaccount  ;

        private Guid? _entitiesaccountid  ;

        private MasterCategory _entitiesmastercategory  ;

        private Guid _entitiesmastercategoryid  ;

#endregion
    }
    public class ScheduledTransaction : Entity
    {
        [JsonIgnore]
        public List<UpcomingInstance> UpcomingInstances { get => _upcominginstances ; set{ _upcominginstances = value;OnPropertyChanged();} } 
        [JsonProperty("transfer_account_id")]
        [ForeignKey(nameof(TransferAccount))]
        public Guid TransferAccountId { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account TransferAccount { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        [JsonProperty("transaction_id")]
        [ForeignKey(nameof(Transaction))]
        public Guid? TransactionId { get => _transactionid ; set{ _transactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Transaction Transaction { get => _transaction ; set{ _transaction = value;OnPropertyChanged();} } 
        [JsonProperty("memo")]
        public string Memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        [JsonProperty("frequency")]
        public string Frequency { get => _frequency ; set{ _frequency = value;OnPropertyChanged();} } 
        [JsonProperty("flag")]
        public string Flag { get => _flag ; set{ _flag = value;OnPropertyChanged();} } 
        [JsonProperty("entities_subcategory_id")]
        [ForeignKey(nameof(EntitiesSubcategory))]
        public Guid EntitiesSubcategoryId { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Subcategory EntitiesSubcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        [JsonProperty("entities_payee_id")]
        [ForeignKey(nameof(EntitiesPayee))]
        public Guid EntitiesPayeeId { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Payee EntitiesPayee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        [JsonProperty("entities_account_id")]
        [ForeignKey(nameof(EntitiesAccount))]
        public Guid EntitiesAccountId { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account EntitiesAccount { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        [JsonProperty("date")]
        [NotMapped]
        public Date Date { get => _date ; set{ _date = value;OnPropertyChanged();} } 
            public DateTime DateValue { get => Date.Value ; set{ Date.Value = value;OnPropertyChanged(nameof(Date));} } 
        [JsonProperty("amount")]
        [NotMapped]
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
            public decimal AmountValue { get => Amount.Value ; set{ Amount.Value = value;OnPropertyChanged(nameof(Amount));} } 

#region fields
        private Amount _amount  = new Amount();

        private Date _date  = new Date();

        private string _flag  ;

        private string _frequency  ;

        private string _memo  ;

        private Account _entitiesaccount  ;

        private Guid _entitiesaccountid  ;

        private Payee _entitiespayee  ;

        private Guid _entitiespayeeid  ;

        private Subcategory _entitiessubcategory  ;

        private Guid _entitiessubcategoryid  ;

        private Transaction _transaction  ;

        private Guid? _transactionid  ;

        private Account _transferaccount  ;

        private Guid _transferaccountid  ;

        private List<UpcomingInstance> _upcominginstances  ;

#endregion
    }
    public class ScheduledSubtransaction : Entity
    {
        [JsonProperty("transfer_account_id")]
        [ForeignKey(nameof(TransferAccount))]
        public Guid TransferAccountId { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account TransferAccount { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        [JsonProperty("sortable_index")]
        public int SortableIndex { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        [JsonProperty("memo")]
        public string Memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        [JsonProperty("entities_subcategory_id")]
        [ForeignKey(nameof(EntitiesSubcategory))]
        public Guid EntitiesSubcategoryId { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Subcategory EntitiesSubcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        [JsonProperty("entities_scheduled_transaction_id")]
        [ForeignKey(nameof(EntitiesScheduledTransaction))]
        public Guid EntitiesScheduledTransactionId { get => _entitiesscheduledtransactionid ; set{ _entitiesscheduledtransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Transaction EntitiesScheduledTransaction { get => _entitiesscheduledtransaction ; set{ _entitiesscheduledtransaction = value;OnPropertyChanged();} } 
        [JsonProperty("entities_payee_id")]
        [ForeignKey(nameof(EntitiesPayee))]
        public Guid EntitiesPayeeId { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Payee EntitiesPayee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        [JsonProperty("amount")]
        [NotMapped]
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
            public decimal AmountValue { get => Amount.Value ; set{ Amount.Value = value;OnPropertyChanged(nameof(Amount));} } 

#region fields
        private Amount _amount  = new Amount();

        private string _memo  ;

        private int _sortableindex  ;

        private Account _transferaccount  ;

        private Guid _transferaccountid  ;

        private Payee _entitiespayee  ;

        private Guid _entitiespayeeid  ;

        private Transaction _entitiesscheduledtransaction  ;

        private Guid _entitiesscheduledtransactionid  ;

        private Subcategory _entitiessubcategory  ;

        private Guid _entitiessubcategoryid  ;

#endregion
    }
    public class PayeeLocation : Entity
    {
        [JsonProperty("longitude")]
        public string Longitude { get => _longitude ; set{ _longitude = value;OnPropertyChanged();} } 
        [JsonProperty("latitude")]
        public string Latitude { get => _latitude ; set{ _latitude = value;OnPropertyChanged();} } 
        [JsonProperty("entities_payee_id")]
        [ForeignKey(nameof(EntitiesPayee))]
        public Guid EntitiesPayeeId { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Payee EntitiesPayee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 

#region fields
        private Payee _entitiespayee  ;

        private Guid _entitiespayeeid  ;

        private string _latitude  ;

        private string _longitude  ;

#endregion
    }
    public class Payee : Entity
    {
        [JsonProperty("rename_on_import_enabled")]
        public string RenameOnImportEnabled { get => _renameonimportenabled ; set{ _renameonimportenabled = value;OnPropertyChanged();} } 
        [JsonProperty("name")]
        public string Name { get => _name ; set{ _name = value;OnPropertyChanged();} } 
        [JsonProperty("internal_name")]
        public string InternalName { get => _internalname ; set{ _internalname = value;OnPropertyChanged();} } 
        [JsonProperty("entities_account_id")]
        [ForeignKey(nameof(EntitiesAccount))]
        public Guid? EntitiesAccountId { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Account EntitiesAccount { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        [JsonProperty("enabled")]
        public bool Enabled { get => _enabled ; set{ _enabled = value;OnPropertyChanged();} } 
        [JsonProperty("auto_fill_subcategory_id")]
        [ForeignKey(nameof(AutoFillSubcategory))]
        public Guid? AutoFillSubcategoryId { get => _autofillsubcategoryid ; set{ _autofillsubcategoryid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Subcategory AutoFillSubcategory { get => _autofillsubcategory ; set{ _autofillsubcategory = value;OnPropertyChanged();} } 
        [JsonProperty("auto_fill_subcategory_enabled")]
        public string AutoFillSubcategoryEnabled { get => _autofillsubcategoryenabled ; set{ _autofillsubcategoryenabled = value;OnPropertyChanged();} } 
        [JsonProperty("auto_fill_memo_enabled")]
        public string AutoFillMemoEnabled { get => _autofillmemoenabled ; set{ _autofillmemoenabled = value;OnPropertyChanged();} } 
        [JsonProperty("auto_fill_memo")]
        public string AutoFillMemo { get => _autofillmemo ; set{ _autofillmemo = value;OnPropertyChanged();} } 
        [JsonProperty("auto_fill_amount_enabled")]
        public string AutoFillAmountEnabled { get => _autofillamountenabled ; set{ _autofillamountenabled = value;OnPropertyChanged();} } 
        [JsonProperty("auto_fill_amount")]
        [NotMapped]
        public Amount AutoFillAmount { get => _autofillamount ; set{ _autofillamount = value;OnPropertyChanged();} } 
            public decimal AutoFillAmountValue { get => AutoFillAmount.Value ; set{ AutoFillAmount.Value = value;OnPropertyChanged(nameof(AutoFillAmount));} } 

#region fields
        private Amount _autofillamount  = new Amount();

        private string _autofillamountenabled  ;

        private string _autofillmemo  ;

        private string _autofillmemoenabled  ;

        private string _autofillsubcategoryenabled  ;

        private Subcategory _autofillsubcategory  ;

        private Guid? _autofillsubcategoryid  ;

        private bool _enabled  ;

        private Account _entitiesaccount  ;

        private Guid? _entitiesaccountid  ;

        private string _internalname  ;

        private string _name  ;

        private string _renameonimportenabled  ;

#endregion
    }
    public class MonthlySubcategoryBudgetCalculation : Entity
    {
        [JsonProperty("upcoming_transactions_count")]
        public string UpcomingTransactionsCount { get => _upcomingtransactionscount ; set{ _upcomingtransactionscount = value;OnPropertyChanged();} } 
        [JsonProperty("upcoming_transactions")]
        [NotMapped]
        public Amount UpcomingTransactions { get => _upcomingtransactions ; set{ _upcomingtransactions = value;OnPropertyChanged();} } 
            public decimal UpcomingTransactionsValue { get => UpcomingTransactions.Value ; set{ UpcomingTransactions.Value = value;OnPropertyChanged(nameof(UpcomingTransactions));} } 
        [JsonProperty("unbudgeted_credit_outflows")]
        [NotMapped]
        public Amount UnbudgetedCreditOutflows { get => _unbudgetedcreditoutflows ; set{ _unbudgetedcreditoutflows = value;OnPropertyChanged();} } 
            public decimal UnbudgetedCreditOutflowsValue { get => UnbudgetedCreditOutflows.Value ; set{ UnbudgetedCreditOutflows.Value = value;OnPropertyChanged(nameof(UnbudgetedCreditOutflows));} } 
        [JsonProperty("unbudgeted_cash_outflows")]
        [NotMapped]
        public Amount UnbudgetedCashOutflows { get => _unbudgetedcashoutflows ; set{ _unbudgetedcashoutflows = value;OnPropertyChanged();} } 
            public decimal UnbudgetedCashOutflowsValue { get => UnbudgetedCashOutflows.Value ; set{ UnbudgetedCashOutflows.Value = value;OnPropertyChanged(nameof(UnbudgetedCashOutflows));} } 
        [JsonProperty("spent_previous_month")]
        [NotMapped]
        public Amount SpentPreviousMonth { get => _spentpreviousmonth ; set{ _spentpreviousmonth = value;OnPropertyChanged();} } 
            public decimal SpentPreviousMonthValue { get => SpentPreviousMonth.Value ; set{ SpentPreviousMonth.Value = value;OnPropertyChanged(nameof(SpentPreviousMonth));} } 
        [JsonProperty("spent_average")]
        [NotMapped]
        public Amount SpentAverage { get => _spentaverage ; set{ _spentaverage = value;OnPropertyChanged();} } 
            public decimal SpentAverageValue { get => SpentAverage.Value ; set{ SpentAverage.Value = value;OnPropertyChanged(nameof(SpentAverage));} } 
        [JsonProperty("positive_cash_outflows")]
        [NotMapped]
        public Amount PositiveCashOutflows { get => _positivecashoutflows ; set{ _positivecashoutflows = value;OnPropertyChanged();} } 
            public decimal PositiveCashOutflowsValue { get => PositiveCashOutflows.Value ; set{ PositiveCashOutflows.Value = value;OnPropertyChanged(nameof(PositiveCashOutflows));} } 
        [JsonProperty("payment_previous_month")]
        [NotMapped]
        public Amount PaymentPreviousMonth { get => _paymentpreviousmonth ; set{ _paymentpreviousmonth = value;OnPropertyChanged();} } 
            public decimal PaymentPreviousMonthValue { get => PaymentPreviousMonth.Value ; set{ PaymentPreviousMonth.Value = value;OnPropertyChanged(nameof(PaymentPreviousMonth));} } 
        [JsonProperty("payment_average")]
        [NotMapped]
        public Amount PaymentAverage { get => _paymentaverage ; set{ _paymentaverage = value;OnPropertyChanged();} } 
            public decimal PaymentAverageValue { get => PaymentAverage.Value ; set{ PaymentAverage.Value = value;OnPropertyChanged(nameof(PaymentAverage));} } 
        [JsonProperty("overspending_affects_buffer")]
        public string OverspendingAffectsBuffer { get => _overspendingaffectsbuffer ; set{ _overspendingaffectsbuffer = value;OnPropertyChanged();} } 
        [JsonProperty("goal_under_funded")]
        public string GoalUnderFunded { get => _goalunderfunded ; set{ _goalunderfunded = value;OnPropertyChanged();} } 
        [JsonProperty("goal_target")]
        public string GoalTarget { get => _goaltarget ; set{ _goaltarget = value;OnPropertyChanged();} } 
        [JsonProperty("goal_percentage_complete")]
        public string GoalPercentageComplete { get => _goalpercentagecomplete ; set{ _goalpercentagecomplete = value;OnPropertyChanged();} } 
        [JsonProperty("goal_overall_left")]
        [NotMapped]
        public Amount GoalOverallLeft { get => _goaloverallleft ; set{ _goaloverallleft = value;OnPropertyChanged();} } 
            public decimal GoalOverallLeftValue { get => GoalOverallLeft.Value ; set{ GoalOverallLeft.Value = value;OnPropertyChanged(nameof(GoalOverallLeft));} } 
        [JsonProperty("goal_overall_funded")]
        [NotMapped]
        public Amount GoalOverallFunded { get => _goaloverallfunded ; set{ _goaloverallfunded = value;OnPropertyChanged();} } 
            public decimal GoalOverallFundedValue { get => GoalOverallFunded.Value ; set{ GoalOverallFunded.Value = value;OnPropertyChanged(nameof(GoalOverallFunded));} } 
        [JsonProperty("goal_expected_completion")]
        public string GoalExpectedCompletion { get => _goalexpectedcompletion ; set{ _goalexpectedcompletion = value;OnPropertyChanged();} } 
        [JsonProperty("entities_monthly_subcategory_budget_id")]
        [ForeignKey(nameof(EntitiesMonthlySubcategoryBudget))]
        public Guid EntitiesMonthlySubcategoryBudgetId { get => _entitiesmonthlysubcategorybudgetid ; set{ _entitiesmonthlysubcategorybudgetid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public MonthlySubcategoryBudget EntitiesMonthlySubcategoryBudget { get => _entitiesmonthlysubcategorybudget ; set{ _entitiesmonthlysubcategorybudget = value;OnPropertyChanged();} } 
        [JsonProperty("credit_outflows")]
        [NotMapped]
        public Amount CreditOutflows { get => _creditoutflows ; set{ _creditoutflows = value;OnPropertyChanged();} } 
            public decimal CreditOutflowsValue { get => CreditOutflows.Value ; set{ CreditOutflows.Value = value;OnPropertyChanged(nameof(CreditOutflows));} } 
        [JsonProperty("cash_outflows")]
        [NotMapped]
        public Amount CashOutflows { get => _cashoutflows ; set{ _cashoutflows = value;OnPropertyChanged();} } 
            public decimal CashOutflowsValue { get => CashOutflows.Value ; set{ CashOutflows.Value = value;OnPropertyChanged(nameof(CashOutflows));} } 
        [JsonProperty("budgeted_spending")]
        [NotMapped]
        public Amount BudgetedSpending { get => _budgetedspending ; set{ _budgetedspending = value;OnPropertyChanged();} } 
            public decimal BudgetedSpendingValue { get => BudgetedSpending.Value ; set{ BudgetedSpending.Value = value;OnPropertyChanged(nameof(BudgetedSpending));} } 
        [JsonProperty("budgeted_previous_month")]
        [NotMapped]
        public Amount BudgetedPreviousMonth { get => _budgetedpreviousmonth ; set{ _budgetedpreviousmonth = value;OnPropertyChanged();} } 
            public decimal BudgetedPreviousMonthValue { get => BudgetedPreviousMonth.Value ; set{ BudgetedPreviousMonth.Value = value;OnPropertyChanged(nameof(BudgetedPreviousMonth));} } 
        [JsonProperty("budgeted_credit_outflows")]
        [NotMapped]
        public Amount BudgetedCreditOutflows { get => _budgetedcreditoutflows ; set{ _budgetedcreditoutflows = value;OnPropertyChanged();} } 
            public decimal BudgetedCreditOutflowsValue { get => BudgetedCreditOutflows.Value ; set{ BudgetedCreditOutflows.Value = value;OnPropertyChanged(nameof(BudgetedCreditOutflows));} } 
        [JsonProperty("budgeted_cash_outflows")]
        [NotMapped]
        public Amount BudgetedCashOutflows { get => _budgetedcashoutflows ; set{ _budgetedcashoutflows = value;OnPropertyChanged();} } 
            public decimal BudgetedCashOutflowsValue { get => BudgetedCashOutflows.Value ; set{ BudgetedCashOutflows.Value = value;OnPropertyChanged(nameof(BudgetedCashOutflows));} } 
        [JsonProperty("budgeted_average")]
        [NotMapped]
        public Amount BudgetedAverage { get => _budgetedaverage ; set{ _budgetedaverage = value;OnPropertyChanged();} } 
            public decimal BudgetedAverageValue { get => BudgetedAverage.Value ; set{ BudgetedAverage.Value = value;OnPropertyChanged(nameof(BudgetedAverage));} } 
        [JsonProperty("balance_previous_month")]
        [NotMapped]
        public Amount BalancePreviousMonth { get => _balancepreviousmonth ; set{ _balancepreviousmonth = value;OnPropertyChanged();} } 
            public decimal BalancePreviousMonthValue { get => BalancePreviousMonth.Value ; set{ BalancePreviousMonth.Value = value;OnPropertyChanged(nameof(BalancePreviousMonth));} } 
        [JsonProperty("balance")]
        [NotMapped]
        public Amount Balance { get => _balance ; set{ _balance = value;OnPropertyChanged();} } 
            public decimal BalanceValue { get => Balance.Value ; set{ Balance.Value = value;OnPropertyChanged(nameof(Balance));} } 
        [JsonProperty("all_spending_since_last_payment")]
        [NotMapped]
        public Amount AllSpendingSinceLastPayment { get => _allspendingsincelastpayment ; set{ _allspendingsincelastpayment = value;OnPropertyChanged();} } 
            public decimal AllSpendingSinceLastPaymentValue { get => AllSpendingSinceLastPayment.Value ; set{ AllSpendingSinceLastPayment.Value = value;OnPropertyChanged(nameof(AllSpendingSinceLastPayment));} } 
        [JsonProperty("all_spending")]
        [NotMapped]
        public Amount AllSpending { get => _allspending ; set{ _allspending = value;OnPropertyChanged();} } 
            public decimal AllSpendingValue { get => AllSpending.Value ; set{ AllSpending.Value = value;OnPropertyChanged(nameof(AllSpending));} } 
        [JsonProperty("additional_to_be_budgeted")]
        public string AdditionalToBeBudgeted { get => _additionaltobebudgeted ; set{ _additionaltobebudgeted = value;OnPropertyChanged();} } 

#region fields
        private string _additionaltobebudgeted  ;

        private Amount _allspending  = new Amount();

        private Amount _allspendingsincelastpayment  = new Amount();

        private Amount _balance  = new Amount();

        private Amount _balancepreviousmonth  = new Amount();

        private Amount _budgetedaverage  = new Amount();

        private Amount _budgetedcashoutflows  = new Amount();

        private Amount _budgetedcreditoutflows  = new Amount();

        private Amount _budgetedpreviousmonth  = new Amount();

        private Amount _budgetedspending  = new Amount();

        private Amount _cashoutflows  = new Amount();

        private Amount _creditoutflows  = new Amount();

        private MonthlySubcategoryBudget _entitiesmonthlysubcategorybudget  ;

        private Guid _entitiesmonthlysubcategorybudgetid  ;

        private string _goalexpectedcompletion  ;

        private Amount _goaloverallfunded  = new Amount();

        private Amount _goaloverallleft  = new Amount();

        private string _goalpercentagecomplete  ;

        private string _goaltarget  ;

        private string _goalunderfunded  ;

        private string _overspendingaffectsbuffer  ;

        private Amount _paymentaverage  = new Amount();

        private Amount _paymentpreviousmonth  = new Amount();

        private Amount _spentaverage  = new Amount();

        private Amount _spentpreviousmonth  = new Amount();

        private Amount _unbudgetedcashoutflows  = new Amount();

        private Amount _unbudgetedcreditoutflows  = new Amount();

        private Amount _upcomingtransactions  = new Amount();

        private string _upcomingtransactionscount  ;

        private Amount _positivecashoutflows  = new Amount();

#endregion
    }
}
