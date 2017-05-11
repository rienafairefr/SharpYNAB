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
        public int sortable_index { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        public bool on_budget { get => _onbudget ; set{ _onbudget = value;OnPropertyChanged();} } 
        public string note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        public Date last_reconciled_date { get => _lastreconcileddate ; set{ _lastreconcileddate = value;OnPropertyChanged();} } 
        public Date last_reconciled_balance { get => _lastreconciledbalance ; set{ _lastreconciledbalance = value;OnPropertyChanged();} } 
        public string last_entered_check_number { get => _lastenteredchecknumber ; set{ _lastenteredchecknumber = value;OnPropertyChanged();} } 
        public bool hidden { get => _hidden ; set{ _hidden = value;OnPropertyChanged();} } 
        public string direct_import_account_name { get => _directimportaccountname ; set{ _directimportaccountname = value;OnPropertyChanged();} } 
        public string direct_import_institution_name { get => _directimportinstitutionname ; set{ _directimportinstitutionname = value;OnPropertyChanged();} } 
        public string direct_import_status { get => _directimportstatus ; set{ _directimportstatus = value;OnPropertyChanged();} } 
        public string direct_connect_last_error_code { get => _directconnectlasterrorcode ; set{ _directconnectlasterrorcode = value;OnPropertyChanged();} } 
        public Date direct_connect_last_imported_at { get => _directconnectlastimportedat ; set{ _directconnectlastimportedat = value;OnPropertyChanged();} } 
        public Guid? direct_connect_institution_id { get => _directconnectinstitutionid ; set{ _directconnectinstitutionid = value;OnPropertyChanged();} } 
        public Guid? direct_connect_account_id { get => _directconnectaccountid ; set{ _directconnectaccountid = value;OnPropertyChanged();} } 
        public bool direct_connect_enabled { get => _directconnectenabled ; set{ _directconnectenabled = value;OnPropertyChanged();} } 
        public AccountType account_type { get => _accounttype ; set{ _accounttype = value;OnPropertyChanged();} } 
        public string account_name { get => _accountname ; set{ _accountname = value;OnPropertyChanged();} } 
        private string _accountname ;
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
        public string warning_count { get => _warningcount ; set{ _warningcount = value;OnPropertyChanged();} } 
        public Amount uncleared_balance { get => _unclearedbalance ; set{ _unclearedbalance = value;OnPropertyChanged();} } 
        public string transaction_count { get => _transactioncount ; set{ _transactioncount = value;OnPropertyChanged();} } 
        public string info_count { get => _infocount ; set{ _infocount = value;OnPropertyChanged();} } 
        public Guid entities_account_id { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account entities_account { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        public string error_count { get => _errorcount ; set{ _errorcount = value;OnPropertyChanged();} } 
        public Amount cleared_balance { get => _clearedbalance ; set{ _clearedbalance = value;OnPropertyChanged();} } 
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
        public string skip_import { get => _skipimport ; set{ _skipimport = value;OnPropertyChanged();} } 
        public string should_import_memos { get => _shouldimportmemos ; set{ _shouldimportmemos = value;OnPropertyChanged();} } 
        public string should_flip_payees_memos { get => _shouldflippayeesmemos ; set{ _shouldflippayeesmemos = value;OnPropertyChanged();} } 
        public string shortened_account_id { get => _shortenedaccountid ; set{ _shortenedaccountid = value;OnPropertyChanged();} } 
        public string salt { get => _salt ; set{ _salt = value;OnPropertyChanged();} } 
        public string hash { get => _hash ; set{ _hash = value;OnPropertyChanged();} } 
        public string fid { get => _fid ; set{ _fid = value;OnPropertyChanged();} } 
        public Guid entities_account_id { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account entities_account { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        public Date date_sequence { get => _datesequence ; set{ _datesequence = value;OnPropertyChanged();} } 
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
        public string operand { get => _operand ; set{ _operand = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Payee entities_payee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        public Guid entities_payee_id { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 
        public string @operator { get => _operator ; set{ _operator = value;OnPropertyChanged();} } 
        private Guid _entitiespayeeid ;
        private Payee _entitiespayee ;
        private string _operator ;
        private string _operand ;
    }
    public class MasterCategory : Entity
    {
        public int sortable_index { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        public string note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        public string name { get => _name ; set{ _name = value;OnPropertyChanged();} } 
        public bool? is_hidden { get => _ishidden ; set{ _ishidden = value;OnPropertyChanged();} } 
        public string internal_name { get => _internalname ; set{ _internalname = value;OnPropertyChanged();} } 
        public bool deletable { get => _deletable ; set{ _deletable = value;OnPropertyChanged();} } 
        private bool _deletable ;
        private string _internalname ;
        private bool? _ishidden ;
        private string _name ;
        private string _note ;
        private int _sortableindex ;
    }
    public class MonthlyAccountCalculation : Entity
    {
        public string warning_count { get => _warningcount ; set{ _warningcount = value;OnPropertyChanged();} } 
        public Amount uncleared_balance { get => _unclearedbalance ; set{ _unclearedbalance = value;OnPropertyChanged();} } 
        public string transaction_count { get => _transactioncount ; set{ _transactioncount = value;OnPropertyChanged();} } 
        public Amount rolling_balance { get => _rollingbalance ; set{ _rollingbalance = value;OnPropertyChanged();} } 
        public string month { get => _month ; set{ _month = value;OnPropertyChanged();} } 
        public string info_count { get => _infocount ; set{ _infocount = value;OnPropertyChanged();} } 
        public string error_count { get => _errorcount ; set{ _errorcount = value;OnPropertyChanged();} } 
        public Guid entities_account_id { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account entities_account { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        public Amount cleared_balance { get => _clearedbalance ; set{ _clearedbalance = value;OnPropertyChanged();} } 
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
        public string note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        public Date month { get => _month ; set{ _month = value;OnPropertyChanged();} } 
        private Date _month ;
        private string _note ;
    }
    public class MonthlyBudgetCalculation : Entity
    {
        public Amount uncategorized_credit_outflows { get => _uncategorizedcreditoutflows ; set{ _uncategorizedcreditoutflows = value;OnPropertyChanged();} } 
        public Amount uncategorized_cash_outflows { get => _uncategorizedcashoutflows ; set{ _uncategorizedcashoutflows = value;OnPropertyChanged();} } 
        public Amount uncategorized_balance { get => _uncategorizedbalance ; set{ _uncategorizedbalance = value;OnPropertyChanged();} } 
        public Amount previous_income { get => _previousincome ; set{ _previousincome = value;OnPropertyChanged();} } 
        public Amount over_spent { get => _overspent ; set{ _overspent = value;OnPropertyChanged();} } 
        public Amount immediate_income { get => _immediateincome ; set{ _immediateincome = value;OnPropertyChanged();} } 
        public Amount hidden_credit_outflows { get => _hiddencreditoutflows ; set{ _hiddencreditoutflows = value;OnPropertyChanged();} } 
        public Amount hidden_cash_outflows { get => _hiddencashoutflows ; set{ _hiddencashoutflows = value;OnPropertyChanged();} } 
        public Amount hidden_budgeted { get => _hiddenbudgeted ; set{ _hiddenbudgeted = value;OnPropertyChanged();} } 
        public Amount hidden_balance { get => _hiddenbalance ; set{ _hiddenbalance = value;OnPropertyChanged();} } 
        public Guid entities_monthly_budget_id { get => _entitiesmonthlybudgetid ; set{ _entitiesmonthlybudgetid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public MonthlyBudget entities_monthly_budget { get => _entitiesmonthlybudget ; set{ _entitiesmonthlybudget = value;OnPropertyChanged();} } 
        public Amount deferred_income { get => _deferredincome ; set{ _deferredincome = value;OnPropertyChanged();} } 
        public Amount credit_outflows { get => _creditoutflows ; set{ _creditoutflows = value;OnPropertyChanged();} } 
        public Amount cash_outflows { get => _cashoutflows ; set{ _cashoutflows = value;OnPropertyChanged();} } 
        public string calculation_notes { get => _calculationnotes ; set{ _calculationnotes = value;OnPropertyChanged();} } 
        public string budgeted { get => _budgeted ; set{ _budgeted = value;OnPropertyChanged();} } 
        public string balance { get => _balance ; set{ _balance = value;OnPropertyChanged();} } 
        public string available_to_budget { get => _availabletobudget ; set{ _availabletobudget = value;OnPropertyChanged();} } 
        public string age_of_money { get => _ageofmoney ; set{ _ageofmoney = value;OnPropertyChanged();} } 
        public Amount additional_to_be_budgeted { get => _additionaltobebudgeted ; set{ _additionaltobebudgeted = value;OnPropertyChanged();} } 
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
    public class MonthlySubCategoryBudget : Entity
    {
        public string overspending_handling { get => _overspendinghandling ; set{ _overspendinghandling = value;OnPropertyChanged();} } 
        public string note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        public Guid entities_subcategory_id { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public SubCategory entities_subcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        public Guid entities_monthly_budget_id { get => _entitiesmonthlybudgetid ; set{ _entitiesmonthlybudgetid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public MonthlyBudget entities_monthly_budget { get => _entitiesmonthlybudget ; set{ _entitiesmonthlybudget = value;OnPropertyChanged();} } 
        public Amount budgeted { get => _budgeted ; set{ _budgeted = value;OnPropertyChanged();} } 
        private Amount _budgeted ;
        private MonthlyBudget _entitiesmonthlybudget ;
        private Guid _entitiesmonthlybudgetid ;
        private SubCategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private string _note ;
        private string _overspendinghandling ;
    }
    public class Setting : Entity
    {
        public string setting_value { get => _settingvalue ; set{ _settingvalue = value;OnPropertyChanged();} } 
        public string setting_name { get => _settingname ; set{ _settingname = value;OnPropertyChanged();} } 
        private string _settingname ;
        private string _settingvalue ;
    }
    public class UpcomingInstance : Entity
    {
        public Guid scheduledtransaction_id { get => _scheduledtransactionid ; set{ _scheduledtransactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public ScheduledTransaction scheduledtransaction { get => _scheduledtransaction ; set{ _scheduledtransaction = value;OnPropertyChanged();} } 
        private ScheduledTransaction _scheduledtransaction ;
        private Guid _scheduledtransactionid ;
    }
    public class Transaction : Entity
    {
        public string ynab_id { get => _ynabid ; set{ _ynabid = value;OnPropertyChanged();} } 
        [ForeignKey(nameof(transfer_transaction))]
        public Guid? transfer_transaction_id { get => _transfertransactionid ; set{ _transfertransactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Transaction transfer_transaction { get => _transfertransaction ; set{ _transfertransaction = value;OnPropertyChanged();} } 
        public Guid? transfer_subtransaction_id { get => _transfersubtransactionid ; set{ _transfersubtransactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public SubTransaction transfer_subtransaction { get => _transfersubtransaction ; set{ _transfersubtransaction = value;OnPropertyChanged();} } 
        public Guid? transfer_account_id { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account transfer_account { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        public Amount subcategory_credit_amount_preceding { get => _subcategorycreditamountpreceding ; set{ _subcategorycreditamountpreceding = value;OnPropertyChanged();} } 
        public string source { get => _source ; set{ _source = value;OnPropertyChanged();} } 
        [ForeignKey(nameof(matched_transaction))]
        public Guid? matched_transaction_id { get => _matchedtransactionid ; set{ _matchedtransactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Transaction matched_transaction { get => _matchedtransaction ; set{ _matchedtransaction = value;OnPropertyChanged();} } 
        public string memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        public string imported_payee { get => _importedpayee ; set{ _importedpayee = value;OnPropertyChanged();} } 
        public Date imported_date { get => _importeddate ; set{ _importeddate = value;OnPropertyChanged();} } 
        public string flag { get => _flag ; set{ _flag = value;OnPropertyChanged();} } 
        public Guid? entities_scheduled_transaction_id { get => _entitiesscheduledtransactionid ; set{ _entitiesscheduledtransactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public ScheduledTransaction entities_scheduled_transaction { get => _entitiesscheduledtransaction ; set{ _entitiesscheduledtransaction = value;OnPropertyChanged();} } 
        public Guid entities_subcategory_id { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public SubCategory entities_subcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        public Guid entities_payee_id { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Payee entities_payee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        public Guid entities_account_id { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account entities_account { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        public Date date_entered_from_schedule { get => _dateenteredfromschedule ; set{ _dateenteredfromschedule = value;OnPropertyChanged();} } 
        public Date date { get => _date ; set{ _date = value;OnPropertyChanged();} } 
        public bool? credit_amount_adjusted { get => _creditamountadjusted ; set{ _creditamountadjusted = value;OnPropertyChanged();} } 
        public Amount credit_amount { get => _creditamount ; set{ _creditamount = value;OnPropertyChanged();} } 
        public string cleared { get => _cleared ; set{ _cleared = value;OnPropertyChanged();} } 
        public string check_number { get => _checknumber ; set{ _checknumber = value;OnPropertyChanged();} } 
        public Amount cash_amount { get => _cashamount ; set{ _cashamount = value;OnPropertyChanged();} } 
        public Amount amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        public bool accepted { get => _accepted ; set{ _accepted = value;OnPropertyChanged();} } 
        private string _ynabid ;
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
        private SubCategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private ScheduledTransaction _entitiesscheduledtransaction ;
        private Guid? _entitiesscheduledtransactionid ;
        private Transaction _matchedtransaction ;
        private Guid? _matchedtransactionid ;
        private Account _transferaccount ;
        private Guid? _transferaccountid ;
        private SubTransaction _transfersubtransaction ;
        private Guid? _transfersubtransactionid ;
        private Transaction _transfertransaction ;
        private Guid? _transfertransactionid ;
    }
    public class SubTransaction : Entity
    {
        public Guid transfer_transaction_id { get => _transfertransactionid ; set{ _transfertransactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Transaction transfer_transaction { get => _transfertransaction ; set{ _transfertransaction = value;OnPropertyChanged();} } 
        public Guid transfer_account_id { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account transfer_account { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        public int subcategory_credit_amount_preceding { get => _subcategorycreditamountpreceding ; set{ _subcategorycreditamountpreceding = value;OnPropertyChanged();} } 
        public int sortable_index { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        public string memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        public string heck_number { get => _hecknumber ; set{ _hecknumber = value;OnPropertyChanged();} } 
        public Guid entities_transaction_d { get => _entitiestransactiond ; set{ _entitiestransactiond = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Transaction entities_transaction { get => _entitiestransaction ; set{ _entitiestransaction = value;OnPropertyChanged();} } 
        public Guid entities_subcategory_id { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public SubCategory entities_subcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        public Guid entities_payee_id { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Payee entities_payee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        public Amount credit_amount { get => _creditamount ; set{ _creditamount = value;OnPropertyChanged();} } 
        public Amount cash_amount { get => _cashamount ; set{ _cashamount = value;OnPropertyChanged();} } 
        public Amount amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        private Amount _amount ;
        private Amount _cashamount ;
        private string _hecknumber ;
        private Amount _creditamount ;
        private string _memo ;
        private int _sortableindex ;
        private int _subcategorycreditamountpreceding  = 0;
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private SubCategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private Transaction _entitiestransaction ;
        private Guid _entitiestransactiond ;
        private Account _transferaccount ;
        private Guid _transferaccountid ;
        private Transaction _transfertransaction ;
        private Guid _transfertransactionid ;
    }
    public class SubCategory : Entity
    {
        public string type { get => _type ; set{ _type = value;OnPropertyChanged();} } 
        public string target_balance_month { get => _targetbalancemonth ; set{ _targetbalancemonth = value;OnPropertyChanged();} } 
        public Amount target_balance { get => _targetbalance ; set{ _targetbalance = value;OnPropertyChanged();} } 
        public int sortable_index { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        public string note { get => _note ; set{ _note = value;OnPropertyChanged();} } 
        public string name { get => _name ; set{ _name = value;OnPropertyChanged();} } 
        public string monthly_funding { get => _monthlyfunding ; set{ _monthlyfunding = value;OnPropertyChanged();} } 
        public bool? is_hidden { get => _ishidden ; set{ _ishidden = value;OnPropertyChanged();} } 
        public string internal_name { get => _internalname ; set{ _internalname = value;OnPropertyChanged();} } 
        public string goal_type { get => _goaltype ; set{ _goaltype = value;OnPropertyChanged();} } 
        public string goal_creation_month { get => _goalcreationmonth ; set{ _goalcreationmonth = value;OnPropertyChanged();} } 
        public Guid entities_master_category_id { get => _entitiesmastercategoryid ; set{ _entitiesmastercategoryid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public MasterCategory entities_master_category { get => _entitiesmastercategory ; set{ _entitiesmastercategory = value;OnPropertyChanged();} } 
        public Guid? entities_account_id { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account entities_account { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
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
        public List<UpcomingInstance> upcoming_instances { get => _upcominginstances ; set{ _upcominginstances = value;OnPropertyChanged();} } 
        public Guid transfer_account_id { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account transfer_account { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        public Guid transaction_id { get => _transactionid ; set{ _transactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Transaction transaction { get => _transaction ; set{ _transaction = value;OnPropertyChanged();} } 
        public string memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        public string frequency { get => _frequency ; set{ _frequency = value;OnPropertyChanged();} } 
        public string flag { get => _flag ; set{ _flag = value;OnPropertyChanged();} } 
        public Guid entities_subcategory_id { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public SubCategory entities_subcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        public Guid entities_payee_id { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Payee entities_payee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        public Guid entities_account_id { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account entities_account { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        public Date date { get => _date ; set{ _date = value;OnPropertyChanged();} } 
        public Amount amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        private Amount _amount ;
        private Date _date ;
        private string _flag ;
        private string _frequency ;
        private string _memo ;
        private Account _entitiesaccount ;
        private Guid _entitiesaccountid ;
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private SubCategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
        private Transaction _transaction ;
        private Guid _transactionid ;
        private Account _transferaccount ;
        private Guid _transferaccountid ;
        private List<UpcomingInstance> _upcominginstances ;
    }
    public class ScheduledSubTransaction : Entity
    {
        public Guid transfer_account_id { get => _transferaccountid ; set{ _transferaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account transfer_account { get => _transferaccount ; set{ _transferaccount = value;OnPropertyChanged();} } 
        public int sortable_index { get => _sortableindex ; set{ _sortableindex = value;OnPropertyChanged();} } 
        public string memo { get => _memo ; set{ _memo = value;OnPropertyChanged();} } 
        public Guid entities_subcategory_id { get => _entitiessubcategoryid ; set{ _entitiessubcategoryid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public SubCategory entities_subcategory { get => _entitiessubcategory ; set{ _entitiessubcategory = value;OnPropertyChanged();} } 
        public Guid entities_scheduled_transaction_id { get => _entitiesscheduledtransactionid ; set{ _entitiesscheduledtransactionid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Transaction entities_scheduled_transaction { get => _entitiesscheduledtransaction ; set{ _entitiesscheduledtransaction = value;OnPropertyChanged();} } 
        public Guid entities_payee_id { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Payee entities_payee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        public Amount amount { get => _amount ; set{ _amount = value;OnPropertyChanged();} } 
        private Amount _amount ;
        private string _memo ;
        private int _sortableindex ;
        private Account _transferaccount ;
        private Guid _transferaccountid ;
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private Transaction _entitiesscheduledtransaction ;
        private Guid _entitiesscheduledtransactionid ;
        private SubCategory _entitiessubcategory ;
        private Guid _entitiessubcategoryid ;
    }
    public class PayeeLocation : Entity
    {
        public string longitude { get => _longitude ; set{ _longitude = value;OnPropertyChanged();} } 
        public string latitude { get => _latitude ; set{ _latitude = value;OnPropertyChanged();} } 
        public Guid entities_payee_id { get => _entitiespayeeid ; set{ _entitiespayeeid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Payee entities_payee { get => _entitiespayee ; set{ _entitiespayee = value;OnPropertyChanged();} } 
        private Payee _entitiespayee ;
        private Guid _entitiespayeeid ;
        private string _latitude ;
        private string _longitude ;
    }
    public class Payee : Entity
    {
        public string rename_on_import_enabled { get => _renameonimportenabled ; set{ _renameonimportenabled = value;OnPropertyChanged();} } 
        public string name { get => _name ; set{ _name = value;OnPropertyChanged();} } 
        public string internal_name { get => _internalname ; set{ _internalname = value;OnPropertyChanged();} } 
        public Guid? entities_account_id { get => _entitiesaccountid ; set{ _entitiesaccountid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public Account entities_account { get => _entitiesaccount ; set{ _entitiesaccount = value;OnPropertyChanged();} } 
        public bool enabled { get => _enabled ; set{ _enabled = value;OnPropertyChanged();} } 
        public Guid? auto_fill_subcategory_id { get => _autofillsubcategoryid ; set{ _autofillsubcategoryid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public SubCategory auto_fill_subcategory { get => _autofillsubcategory ; set{ _autofillsubcategory = value;OnPropertyChanged();} } 
        public string auto_fill_subcategory_enabled { get => _autofillsubcategoryenabled ; set{ _autofillsubcategoryenabled = value;OnPropertyChanged();} } 
        public string auto_fill_memo_enabled { get => _autofillmemoenabled ; set{ _autofillmemoenabled = value;OnPropertyChanged();} } 
        public string auto_fill_memo { get => _autofillmemo ; set{ _autofillmemo = value;OnPropertyChanged();} } 
        public string auto_fill_amount_enabled { get => _autofillamountenabled ; set{ _autofillamountenabled = value;OnPropertyChanged();} } 
        public Amount auto_fill_amount { get => _autofillamount ; set{ _autofillamount = value;OnPropertyChanged();} } 
        private Amount _autofillamount ;
        private string _autofillamountenabled ;
        private string _autofillmemo ;
        private string _autofillmemoenabled ;
        private string _autofillsubcategoryenabled ;
        private SubCategory _autofillsubcategory ;
        private Guid? _autofillsubcategoryid ;
        private bool _enabled ;
        private Account _entitiesaccount ;
        private Guid? _entitiesaccountid ;
        private string _internalname ;
        private string _name ;
        private string _renameonimportenabled ;
    }
    public class MonthlySubCategoryBudgetCalculation : Entity
    {
        public string upcoming_transactions_count { get => _upcomingtransactionscount ; set{ _upcomingtransactionscount = value;OnPropertyChanged();} } 
        public Amount upcoming_transactions { get => _upcomingtransactions ; set{ _upcomingtransactions = value;OnPropertyChanged();} } 
        public Amount unbudgeted_credit_outflows { get => _unbudgetedcreditoutflows ; set{ _unbudgetedcreditoutflows = value;OnPropertyChanged();} } 
        public Amount unbudgeted_cash_outflows { get => _unbudgetedcashoutflows ; set{ _unbudgetedcashoutflows = value;OnPropertyChanged();} } 
        public Amount spent_previous_month { get => _spentpreviousmonth ; set{ _spentpreviousmonth = value;OnPropertyChanged();} } 
        public Amount spent_average { get => _spentaverage ; set{ _spentaverage = value;OnPropertyChanged();} } 
        public Amount positive_cash_outflows { get => _positivecashoutflows ; set{ _positivecashoutflows = value;OnPropertyChanged();} } 
        public Amount payment_previous_month { get => _paymentpreviousmonth ; set{ _paymentpreviousmonth = value;OnPropertyChanged();} } 
        public Amount payment_average { get => _paymentaverage ; set{ _paymentaverage = value;OnPropertyChanged();} } 
        public string overspending_affects_buffer { get => _overspendingaffectsbuffer ; set{ _overspendingaffectsbuffer = value;OnPropertyChanged();} } 
        public string goal_under_funded { get => _goalunderfunded ; set{ _goalunderfunded = value;OnPropertyChanged();} } 
        public string goal_target { get => _goaltarget ; set{ _goaltarget = value;OnPropertyChanged();} } 
        public string goal_percentage_complete { get => _goalpercentagecomplete ; set{ _goalpercentagecomplete = value;OnPropertyChanged();} } 
        public Amount goal_overall_left { get => _goaloverallleft ; set{ _goaloverallleft = value;OnPropertyChanged();} } 
        public Amount goal_overall_funded { get => _goaloverallfunded ; set{ _goaloverallfunded = value;OnPropertyChanged();} } 
        public string goal_expected_completion { get => _goalexpectedcompletion ; set{ _goalexpectedcompletion = value;OnPropertyChanged();} } 
        public Guid entities_monthly_subcategory_budget_id { get => _entitiesmonthlysubcategorybudgetid ; set{ _entitiesmonthlysubcategorybudgetid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public MonthlySubCategoryBudget entities_monthly_subcategory_budget { get => _entitiesmonthlysubcategorybudget ; set{ _entitiesmonthlysubcategorybudget = value;OnPropertyChanged();} } 
        public Amount credit_outflows { get => _creditoutflows ; set{ _creditoutflows = value;OnPropertyChanged();} } 
        public Amount cash_outflows { get => _cashoutflows ; set{ _cashoutflows = value;OnPropertyChanged();} } 
        public Amount budgeted_spending { get => _budgetedspending ; set{ _budgetedspending = value;OnPropertyChanged();} } 
        public Amount budgeted_previous_month { get => _budgetedpreviousmonth ; set{ _budgetedpreviousmonth = value;OnPropertyChanged();} } 
        public Amount budgeted_credit_outflows { get => _budgetedcreditoutflows ; set{ _budgetedcreditoutflows = value;OnPropertyChanged();} } 
        public Amount budgeted_cash_outflows { get => _budgetedcashoutflows ; set{ _budgetedcashoutflows = value;OnPropertyChanged();} } 
        public Amount budgeted_average { get => _budgetedaverage ; set{ _budgetedaverage = value;OnPropertyChanged();} } 
        public Amount balance_previous_month { get => _balancepreviousmonth ; set{ _balancepreviousmonth = value;OnPropertyChanged();} } 
        public Amount balance { get => _balance ; set{ _balance = value;OnPropertyChanged();} } 
        public Amount all_spending_since_last_payment { get => _allspendingsincelastpayment ; set{ _allspendingsincelastpayment = value;OnPropertyChanged();} } 
        public Amount all_spending { get => _allspending ; set{ _allspending = value;OnPropertyChanged();} } 
        public string additional_to_be_budgeted { get => _additionaltobebudgeted ; set{ _additionaltobebudgeted = value;OnPropertyChanged();} } 
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
        private MonthlySubCategoryBudget _entitiesmonthlysubcategorybudget ;
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
