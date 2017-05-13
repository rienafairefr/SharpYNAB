using System;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


// ReSharper disable InconsistentNaming


namespace SharpnYNAB.Schema.Budget
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
        public Date LastReconciledDate { get => _lastreconcileddate ; set{ _lastreconcileddate = value;OnPropertyChanged();} } 
        [JsonProperty("last_reconciled_balance")]
        public Date LastReconciledBalance { get => _lastreconciledbalance ; set{ _lastreconciledbalance = value;OnPropertyChanged();} } 
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
        public Date DirectConnectLastImportedAt { get => _directconnectlastimportedat ; set{ _directconnectlastimportedat = value;OnPropertyChanged();} } 
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
        private string _accountname ;
        private List<AccountCalculation> _accountcalculations ;
        private AccountType _accounttype ;
        private bool _hidden ;
        private string _lastenteredchecknumber ;
        private Date _lastreconciledbalance ;
        private Date _lastreconcileddate ;
        private string _note ;
        private int _sortableindex ;
        private bool _onbudget ;
        private bool _directconnectenabled ;
        private Guid? _directconnectaccountid ;
        private Guid? _directconnectinstitutionid ;
        private Date _directconnectlastimportedat ;
        private string _directconnectlasterrorcode ;
        private string _directimportstatus ;
        private string _directimportinstitutionname ;
        private string _directimportaccountname ;
    }
    public class AccountCalculation : Entity
    {
        [JsonProperty("warning_count")]
        public string WarningCount { get => _warningcount ; set{ _warningcount = value;OnPropertyChanged();} } 
        [JsonProperty("uncleared_balance")]
        public Amount UnclearedBalance { get => _unclearedbalance ; set{ _unclearedbalance = value;OnPropertyChanged();} } 
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
        public Amount ClearedBalance { get => _clearedbalance ; set{ _clearedbalance = value;OnPropertyChanged();} } 
        private Amount _clearedbalance ;
        private string _errorcount ;
        private string _infocount ;
        private string _transactioncount ;
        private Amount _unclearedbalance ;
        private string _warningcount ;
        private Account _entitiesaccount ;
        private Guid _entitiesaccountid ;
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
        public Date DateSequence { get => _datesequence ; set{ _datesequence = value;OnPropertyChanged();} } 
        private Date _datesequence ;
        private string _hash ;
        private string _fid ;
        private string _salt ;
        private string _shortenedaccountid ;
        private string _shouldflippayeesmemos ;
        private string _shouldimportmemos ;
        private string _skipimport ;
        private Account _entitiesaccount ;
        private Guid _entitiesaccountid ;
    }
    public class PayeeRenameCondition : Entity
    {
        [JsonProperty("operand")]
        public string Operand { get => _operand ; set{ _operand = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public Payee EntitiesPayee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        [JsonProperty("entities_payee_id")]
        [ForeignKey(nameof(EntitiesPayee))]
        public Guid EntitiesPayeeId { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 
        [JsonProperty("@operator")]
        public string @operator { get => _operator ; set{ _operator = value;OnPropertyChanged();} } 
        private Guid _entitiespayeeid ;
        private Payee _entitiespayee ;
        private string _operator ;
        private string _operand ;
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
        private bool _deletable ;
        private string _internalname ;
        private bool? _ishidden ;
        private string _name ;
        private string _note ;
        private int _sortableindex ;
    }
    public class MonthlyAccountCalculation : Entity
    {
        [JsonProperty("warning_count")]
        public string WarningCount { get => _warningcount ; set{ _warningcount = value;OnPropertyChanged();} } 
        [JsonProperty("uncleared_balance")]
        public Amount UnclearedBalance { get => _unclearedbalance ; set{ _unclearedbalance = value;OnPropertyChanged();} } 
        [JsonProperty("transaction_count")]
        public string TransactionCount { get => _transactioncount ; set{ _transactioncount = value;OnPropertyChanged();} } 
        [JsonProperty("rolling_balance")]
        public Amount RollingBalance { get => _rollingbalance ; set{ _rollingbalance = value;OnPropertyChanged();} } 
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
        public Amount ClearedBalance { get => _clearedbalance ; set{ _clearedbalance = value;OnPropertyChanged();} } 
        private Amount _clearedbalance ;
        private Account _entitiesaccount ;
        private Guid _entitiesaccountid ;
        private string _errorcount ;
        private string _infocount ;
        private string _month ;
        private string _transactioncount ;
        private Amount _unclearedbalance ;
        private string _warningcount ;
        private Amount _rollingbalance ;
    }
    public class MonthlyBudget : Entity
    {
        [JsonProperty("note")]
        public string Note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        [JsonProperty("month")]
        public Date Month { get => _month ; set{ _month = value;OnPropertyChanged();} } 
        private Date _month ;
        private string _note ;
    }
    public class MonthlyBudgetCalculation : Entity
    {
        [JsonProperty("uncategorized_credit_outflows")]
        public Amount UncategorizedCreditOutflows { get => _uncategorizedcreditoutflows ; set{ _uncategorizedcreditoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("uncategorized_cash_outflows")]
        public Amount UncategorizedCashOutflows { get => _uncategorizedcashoutflows ; set{ _uncategorizedcashoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("uncategorized_balance")]
        public Amount UncategorizedBalance { get => _uncategorizedbalance ; set{ _uncategorizedbalance = value;OnPropertyChanged();} } 
        [JsonProperty("previous_income")]
        public Amount PreviousIncome { get => _previousincome ; set{ _previousincome = value;OnPropertyChanged();} } 
        [JsonProperty("over_spent")]
        public Amount OverSpent { get => _overspent ; set{ _overspent = value;OnPropertyChanged();} } 
        [JsonProperty("immediate_income")]
        public Amount ImmediateIncome { get => _immediateincome ; set{ _immediateincome = value;OnPropertyChanged();} } 
        [JsonProperty("hidden_credit_outflows")]
        public Amount HiddenCreditOutflows { get => _hiddencreditoutflows ; set{ _hiddencreditoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("hidden_cash_outflows")]
        public Amount HiddenCashOutflows { get => _hiddencashoutflows ; set{ _hiddencashoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("hidden_budgeted")]
        public Amount HiddenBudgeted { get => _hiddenbudgeted ; set{ _hiddenbudgeted = value;OnPropertyChanged();} } 
        [JsonProperty("hidden_balance")]
        public Amount HiddenBalance { get => _hiddenbalance ; set{ _hiddenbalance = value;OnPropertyChanged();} } 
        [JsonProperty("entities_monthly_budget_id")]
        [ForeignKey(nameof(EntitiesMonthlyBudget))]
        public Guid EntitiesMonthlyBudgetId { get => _entitiesmonthlybudgetid ; set{ _entitiesmonthlybudgetid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public MonthlyBudget EntitiesMonthlyBudget { get => _entitiesmonthlybudget ; set{ _entitiesmonthlybudget = value;OnPropertyChanged();} } 
        [JsonProperty("deferred_income")]
        public Amount DeferredIncome { get => _deferredincome ; set{ _deferredincome = value;OnPropertyChanged();} } 
        [JsonProperty("credit_outflows")]
        public Amount CreditOutflows { get => _creditoutflows ; set{ _creditoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("cash_outflows")]
        public Amount CashOutflows { get => _cashoutflows ; set{ _cashoutflows = value;OnPropertyChanged();} } 
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
        public Amount AdditionalToBeBudgeted { get => _additionaltobebudgeted ; set{ _additionaltobebudgeted = value;OnPropertyChanged();} } 
        private Amount _additionaltobebudgeted ;
        private string _ageofmoney ;
        private string _availabletobudget ;
        private string _balance ;
        private string _budgeted ;
        private string _calculationnotes ;
        private Amount _cashoutflows ;
        private Amount _creditoutflows ;
        private Amount _deferredincome ;
        private MonthlyBudget _entitiesmonthlybudget ;
        private Guid _entitiesmonthlybudgetid ;
        private Amount _hiddenbalance ;
        private Amount _hiddenbudgeted ;
        private Amount _hiddencashoutflows ;
        private Amount _hiddencreditoutflows ;
        private Amount _immediateincome ;
        private Amount _overspent ;
        private Amount _previousincome ;
        private Amount _uncategorizedbalance ;
        private Amount _uncategorizedcashoutflows ;
        private Amount _uncategorizedcreditoutflows ;
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
        public Amount Budgeted { get => _budgeted ; set{ _budgeted = value;OnPropertyChanged();} } 
        private Amount _budgeted ;
        private MonthlyBudget _entitiesmonthlybudget ;
        private Guid _entitiesmonthlybudgetid ;
        private Subcategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private string _note ;
        private string _overspendinghandling ;
    }
    public class Setting : Entity
    {
        [JsonProperty("setting_value")]
        public string SettingValue { get => _settingvalue ; set{ _settingvalue = value;OnPropertyChanged();} } 
        [JsonProperty("setting_name")]
        public string SettingName { get => _settingname ; set{ _settingname = value;OnPropertyChanged();} } 
        private string _settingname ;
        private string _settingvalue ;
    }
    public class UpcomingInstance : Entity
    {
        [JsonProperty("scheduled_transaction_id")]
        [ForeignKey(nameof(ScheduledTransaction))]
        public Guid ScheduledTransactionId { get => _scheduledtransactionid ; set{ _scheduledtransactionid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public ScheduledTransaction ScheduledTransaction { get => _scheduledtransaction ; set{ _scheduledtransaction = value;OnPropertyChanged();} } 
        private ScheduledTransaction _scheduledtransaction ;
        private Guid _scheduledtransactionid ;
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
        public Amount SubcategoryCreditAmountPreceding { get => _subcategorycreditamountpreceding ; set{ _subcategorycreditamountpreceding = value;OnPropertyChanged();} } 
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
        public Date ImportedDate { get => _importeddate ; set{ _importeddate = value;OnPropertyChanged();} } 
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
        public Date DateEnteredFromSchedule { get => _dateenteredfromschedule ; set{ _dateenteredfromschedule = value;OnPropertyChanged();} } 
        [JsonProperty("date")]
        public Date Date { get => _date ; set{ _date = value;OnPropertyChanged();} } 
        [JsonProperty("credit_amount_adjusted")]
        public bool? CreditAmountAdjusted { get => _creditamountadjusted ; set{ _creditamountadjusted = value;OnPropertyChanged();} } 
        [JsonProperty("credit_amount")]
        public Amount CreditAmount { get => _creditamount ; set{ _creditamount = value;OnPropertyChanged();} } 
        [JsonProperty("cleared")]
        public string Cleared { get => _cleared ; set{ _cleared = value;OnPropertyChanged();} } 
        [JsonProperty("check_number")]
        public string CheckNumber { get => _checknumber ; set{ _checknumber = value;OnPropertyChanged();} } 
        [JsonProperty("cash_amount")]
        public Amount CashAmount { get => _cashamount ; set{ _cashamount = value;OnPropertyChanged();} } 
        [JsonProperty("amount")]
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        [JsonProperty("accepted")]
        public bool Accepted { get => _accepted ; set{ _accepted = value;OnPropertyChanged();} } 
        private string _ynabid ;
        private List<Subtransaction> _subtransactions ;
        private string _memo ;
        private string _source ;
        private Amount _subcategorycreditamountpreceding ;
        private bool _accepted ;
        private Amount _amount ;
        private Amount _cashamount ;
        private string _checknumber ;
        private string _cleared ;
        private Amount _creditamount ;
        private bool? _creditamountadjusted ;
        private Date _date ;
        private Date _dateenteredfromschedule ;
        private string _flag ;
        private Date _importeddate ;
        private string _importedpayee ;
        private Account _entitiesaccount ;
        private Guid _entitiesaccountid ;
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private Subcategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private ScheduledTransaction _entitiesscheduledtransaction ;
        private Guid? _entitiesscheduledtransactionid ;
        private Transaction _matchedtransaction ;
        private Guid? _matchedtransactionid ;
        private Account _transferaccount ;
        private Guid? _transferaccountid ;
        private Subtransaction _transfersubtransaction ;
        private Guid? _transfersubtransactionid ;
        private Transaction _transfertransaction ;
        private Guid? _transfertransactionid ;
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
        public Amount CreditAmount { get => _creditamount ; set{ _creditamount = value;OnPropertyChanged();} } 
        [JsonProperty("cash_amount")]
        public Amount CashAmount { get => _cashamount ; set{ _cashamount = value;OnPropertyChanged();} } 
        [JsonProperty("amount")]
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        private Amount _amount ;
        private Amount _cashamount ;
        private string _hecknumber ;
        private Amount _creditamount ;
        private string _memo ;
        private int _sortableindex ;
        private int _subcategorycreditamountpreceding  = 0;
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private Subcategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private Transaction _entitiestransaction ;
        private Guid _entitiestransactionid ;
        private Account _transferaccount ;
        private Guid _transferaccountid ;
        private Transaction _transfertransaction ;
        private Guid _transfertransactionid ;
    }
    public class Subcategory : Entity
    {
        [JsonProperty("type")]
        public string Type { get => _type ; set{ _type = value;OnPropertyChanged();} } 
        [JsonProperty("target_balance_month")]
        public string TargetBalanceMonth { get => _targetbalancemonth ; set{ _targetbalancemonth = value;OnPropertyChanged();} } 
        [JsonProperty("target_balance")]
        public Amount TargetBalance { get => _targetbalance ; set{ _targetbalance = value;OnPropertyChanged();} } 
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
        private MonthlySubcategoryBudget _monthlysubcategorybudget ;
        private string _goalcreationmonth ;
        private string _goaltype ;
        private string _internalname ;
        private bool? _ishidden  = false;
        private string _monthlyfunding ;
        private string _name ;
        private string _note ;
        private int _sortableindex ;
        private Amount _targetbalance  = 0;
        private string _targetbalancemonth ;
        private string _type ;
        private Account _entitiesaccount ;
        private Guid? _entitiesaccountid ;
        private MasterCategory _entitiesmastercategory ;
        private Guid _entitiesmastercategoryid ;
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
        public Guid TransactionId { get => _transactionid ; set{ _transactionid = value;OnPropertyChanged();} } 
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
        public Date Date { get => _date ; set{ _date = value;OnPropertyChanged();} } 
        [JsonProperty("amount")]
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        private Amount _amount ;
        private Date _date ;
        private string _flag ;
        private string _frequency ;
        private string _memo ;
        private Account _entitiesaccount ;
        private Guid _entitiesaccountid ;
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private Subcategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private Transaction _transaction ;
        private Guid _transactionid ;
        private Account _transferaccount ;
        private Guid _transferaccountid ;
        private List<UpcomingInstance> _upcominginstances ;
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
        public Amount Amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        private Amount _amount ;
        private string _memo ;
        private int _sortableindex ;
        private Account _transferaccount ;
        private Guid _transferaccountid ;
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private Transaction _entitiesscheduledtransaction ;
        private Guid _entitiesscheduledtransactionid ;
        private Subcategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
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
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private string _latitude ;
        private string _longitude ;
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
        public Amount AutoFillAmount { get => _autofillamount ; set{ _autofillamount = value;OnPropertyChanged();} } 
        private Amount _autofillamount ;
        private string _autofillamountenabled ;
        private string _autofillmemo ;
        private string _autofillmemoenabled ;
        private string _autofillsubcategoryenabled ;
        private Subcategory _autofillsubcategory ;
        private Guid? _autofillsubcategoryid ;
        private bool _enabled ;
        private Account _entitiesaccount ;
        private Guid? _entitiesaccountid ;
        private string _internalname ;
        private string _name ;
        private string _renameonimportenabled ;
    }
    public class MonthlySubcategoryBudgetCalculation : Entity
    {
        [JsonProperty("upcoming_transactions_count")]
        public string UpcomingTransactionsCount { get => _upcomingtransactionscount ; set{ _upcomingtransactionscount = value;OnPropertyChanged();} } 
        [JsonProperty("upcoming_transactions")]
        public Amount UpcomingTransactions { get => _upcomingtransactions ; set{ _upcomingtransactions = value;OnPropertyChanged();} } 
        [JsonProperty("unbudgeted_credit_outflows")]
        public Amount UnbudgetedCreditOutflows { get => _unbudgetedcreditoutflows ; set{ _unbudgetedcreditoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("unbudgeted_cash_outflows")]
        public Amount UnbudgetedCashOutflows { get => _unbudgetedcashoutflows ; set{ _unbudgetedcashoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("spent_previous_month")]
        public Amount SpentPreviousMonth { get => _spentpreviousmonth ; set{ _spentpreviousmonth = value;OnPropertyChanged();} } 
        [JsonProperty("spent_average")]
        public Amount SpentAverage { get => _spentaverage ; set{ _spentaverage = value;OnPropertyChanged();} } 
        [JsonProperty("positive_cash_outflows")]
        public Amount PositiveCashOutflows { get => _positivecashoutflows ; set{ _positivecashoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("payment_previous_month")]
        public Amount PaymentPreviousMonth { get => _paymentpreviousmonth ; set{ _paymentpreviousmonth = value;OnPropertyChanged();} } 
        [JsonProperty("payment_average")]
        public Amount PaymentAverage { get => _paymentaverage ; set{ _paymentaverage = value;OnPropertyChanged();} } 
        [JsonProperty("overspending_affects_buffer")]
        public string OverspendingAffectsBuffer { get => _overspendingaffectsbuffer ; set{ _overspendingaffectsbuffer = value;OnPropertyChanged();} } 
        [JsonProperty("goal_under_funded")]
        public string GoalUnderFunded { get => _goalunderfunded ; set{ _goalunderfunded = value;OnPropertyChanged();} } 
        [JsonProperty("goal_target")]
        public string GoalTarget { get => _goaltarget ; set{ _goaltarget = value;OnPropertyChanged();} } 
        [JsonProperty("goal_percentage_complete")]
        public string GoalPercentageComplete { get => _goalpercentagecomplete ; set{ _goalpercentagecomplete = value;OnPropertyChanged();} } 
        [JsonProperty("goal_overall_left")]
        public Amount GoalOverallLeft { get => _goaloverallleft ; set{ _goaloverallleft = value;OnPropertyChanged();} } 
        [JsonProperty("goal_overall_funded")]
        public Amount GoalOverallFunded { get => _goaloverallfunded ; set{ _goaloverallfunded = value;OnPropertyChanged();} } 
        [JsonProperty("goal_expected_completion")]
        public string GoalExpectedCompletion { get => _goalexpectedcompletion ; set{ _goalexpectedcompletion = value;OnPropertyChanged();} } 
        [JsonProperty("entities_monthly_subcategory_budget_id")]
        [ForeignKey(nameof(EntitiesMonthlySubcategoryBudget))]
        public Guid EntitiesMonthlySubcategoryBudgetId { get => _entitiesmonthlysubcategorybudgetid ; set{ _entitiesmonthlysubcategorybudgetid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public MonthlySubcategoryBudget EntitiesMonthlySubcategoryBudget { get => _entitiesmonthlysubcategorybudget ; set{ _entitiesmonthlysubcategorybudget = value;OnPropertyChanged();} } 
        [JsonProperty("credit_outflows")]
        public Amount CreditOutflows { get => _creditoutflows ; set{ _creditoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("cash_outflows")]
        public Amount CashOutflows { get => _cashoutflows ; set{ _cashoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("budgeted_spending")]
        public Amount BudgetedSpending { get => _budgetedspending ; set{ _budgetedspending = value;OnPropertyChanged();} } 
        [JsonProperty("budgeted_previous_month")]
        public Amount BudgetedPreviousMonth { get => _budgetedpreviousmonth ; set{ _budgetedpreviousmonth = value;OnPropertyChanged();} } 
        [JsonProperty("budgeted_credit_outflows")]
        public Amount BudgetedCreditOutflows { get => _budgetedcreditoutflows ; set{ _budgetedcreditoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("budgeted_cash_outflows")]
        public Amount BudgetedCashOutflows { get => _budgetedcashoutflows ; set{ _budgetedcashoutflows = value;OnPropertyChanged();} } 
        [JsonProperty("budgeted_average")]
        public Amount BudgetedAverage { get => _budgetedaverage ; set{ _budgetedaverage = value;OnPropertyChanged();} } 
        [JsonProperty("balance_previous_month")]
        public Amount BalancePreviousMonth { get => _balancepreviousmonth ; set{ _balancepreviousmonth = value;OnPropertyChanged();} } 
        [JsonProperty("balance")]
        public Amount Balance { get => _balance ; set{ _balance = value;OnPropertyChanged();} } 
        [JsonProperty("all_spending_since_last_payment")]
        public Amount AllSpendingSinceLastPayment { get => _allspendingsincelastpayment ; set{ _allspendingsincelastpayment = value;OnPropertyChanged();} } 
        [JsonProperty("all_spending")]
        public Amount AllSpending { get => _allspending ; set{ _allspending = value;OnPropertyChanged();} } 
        [JsonProperty("additional_to_be_budgeted")]
        public string AdditionalToBeBudgeted { get => _additionaltobebudgeted ; set{ _additionaltobebudgeted = value;OnPropertyChanged();} } 
        private string _additionaltobebudgeted ;
        private Amount _allspending ;
        private Amount _allspendingsincelastpayment ;
        private Amount _balance ;
        private Amount _balancepreviousmonth ;
        private Amount _budgetedaverage ;
        private Amount _budgetedcashoutflows ;
        private Amount _budgetedcreditoutflows ;
        private Amount _budgetedpreviousmonth ;
        private Amount _budgetedspending ;
        private Amount _cashoutflows ;
        private Amount _creditoutflows ;
        private MonthlySubcategoryBudget _entitiesmonthlysubcategorybudget ;
        private Guid _entitiesmonthlysubcategorybudgetid ;
        private string _goalexpectedcompletion ;
        private Amount _goaloverallfunded ;
        private Amount _goaloverallleft ;
        private string _goalpercentagecomplete ;
        private string _goaltarget ;
        private string _goalunderfunded ;
        private string _overspendingaffectsbuffer ;
        private Amount _paymentaverage ;
        private Amount _paymentpreviousmonth ;
        private Amount _spentaverage ;
        private Amount _spentpreviousmonth ;
        private Amount _unbudgetedcashoutflows ;
        private Amount _unbudgetedcreditoutflows ;
        private Amount _upcomingtransactions ;
        private string _upcomingtransactionscount ;
        private Amount _positivecashoutflows ;
    }
}
