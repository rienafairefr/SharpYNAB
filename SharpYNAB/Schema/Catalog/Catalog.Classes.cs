using System;
using Newtonsoft.Json;
using SharpYNAB.Schema.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable ExplicitCallerInfoArgument

namespace SharpYNAB.Schema.Catalog
{
    public class BudgetVersion : Entity
    {
        [JsonProperty("version_name")]
        public string VersionName { get => _versionname ; set{ _versionname = value;OnPropertyChanged();} } 
        [JsonProperty("source")]
        public string Source { get => _source ; set{ _source = value;OnPropertyChanged();} } 
        [JsonProperty("last_accessed_on")]
        public DateTime LastAccessedOn { get => _lastaccessedon ; set{ _lastaccessedon = value;OnPropertyChanged();} } 
        [JsonProperty("date_format")]
        [NotMapped]
        public DateFormat DateFormat { get => _dateformat ; set{ _dateformat = value;OnPropertyChanged();} } 
            public string DateFormatFormat { get => DateFormat.Format ; set{ DateFormat.Format = value;OnPropertyChanged(nameof(DateFormat));} } 
        [JsonProperty("currency_format")]
        [NotMapped]
        public CurrencyFormat CurrencyFormat { get => _currencyformat ; set{ _currencyformat = value;OnPropertyChanged();} } 
            public bool CurrencyFormatDisplaySymbol { get => CurrencyFormat.DisplaySymbol ; set{ CurrencyFormat.DisplaySymbol = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
            public string CurrencyFormatIsoCode { get => CurrencyFormat.IsoCode ; set{ CurrencyFormat.IsoCode = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
            public bool CurrencyFormatSymbolFirst { get => CurrencyFormat.SymbolFirst ; set{ CurrencyFormat.SymbolFirst = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
            public string CurrencyFormatCurrencySymbol { get => CurrencyFormat.CurrencySymbol ; set{ CurrencyFormat.CurrencySymbol = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
            public int CurrencyFormatDecimalDigits { get => CurrencyFormat.DecimalDigits ; set{ CurrencyFormat.DecimalDigits = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
            public string CurrencyFormatDecimalSeparator { get => CurrencyFormat.DecimalSeparator ; set{ CurrencyFormat.DecimalSeparator = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
            public string CurrencyFormatGroupSeparator { get => CurrencyFormat.GroupSeparator ; set{ CurrencyFormat.GroupSeparator = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
            public string CurrencyFormatExampleFormat { get => CurrencyFormat.ExampleFormat ; set{ CurrencyFormat.ExampleFormat = value;OnPropertyChanged(nameof(CurrencyFormat));} } 
        [JsonIgnore]
        public CatalogBudget Budget { get => _budget ; set{ _budget = value;OnPropertyChanged();} } 
        [JsonProperty("budget_id")]
        [ForeignKey(nameof(Budget))]
        public Guid BudgetId { get => _budgetid ; set{ _budgetid = value;OnPropertyChanged();} } 

#region fields
        private DateFormat _dateformat ;
        private DateTime _lastaccessedon ;
        private CurrencyFormat _currencyformat ;
        private Guid _budgetid ;
        private CatalogBudget _budget ;
        private string _versionname ;
        private string _source ;
#endregion
    }
    public class CatalogBudget : Entity
    {
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get => _createdat ; set{ _createdat = value;OnPropertyChanged();} } 
        [JsonProperty("budget_name")]
        public string BudgetName { get => _budgetname ; set{ _budgetname = value;OnPropertyChanged();} } 

#region fields
        private string _budgetname ;
        private DateTime? _createdat ;
#endregion
    }
    public class User : Entity
    {
        [JsonProperty("username")]
        public string Username { get => _username ; set{ _username = value;OnPropertyChanged();} } 
        [JsonProperty("trial_expires_on")]
        [NotMapped]
        public Date TrialExpiresOn { get => _trialexpireson ; set{ _trialexpireson = value;OnPropertyChanged();} } 
            public DateTime TrialExpiresOnValue { get => TrialExpiresOn.Value ; set{ TrialExpiresOn.Value = value;OnPropertyChanged(nameof(TrialExpiresOn));} } 
        [JsonProperty("sign_in_count")]
        public int SignInCount { get => _signincount ; set{ _signincount = value;OnPropertyChanged();} } 
        [JsonProperty("is_subscribed")]
        public bool IsSubscribed { get => _issubscribed ; set{ _issubscribed = value;OnPropertyChanged();} } 
        [JsonProperty("feature_flags")]
        public List<FeatureFlag> FeatureFlags { get => _featureflags ; set{ _featureflags = value;OnPropertyChanged();} } 
        [JsonProperty("email")]
        public string Email { get => _email ; set{ _email = value;OnPropertyChanged();} } 

#region fields
        private string _username ;
        private Date _trialexpireson ;
        private string _email ;
        private List<FeatureFlag> _featureflags ;
        private int _signincount ;
        private bool _issubscribed ;
#endregion
    }
    public class UserBudget : Entity
    {
        [JsonProperty("user_id")]
        [ForeignKey(nameof(User))]
        public Guid UserId { get => _userid ; set{ _userid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public User User { get => _user ; set{ _user = value;OnPropertyChanged();} } 
        [JsonProperty("permissions")]
        public int Permissions { get => _permissions ; set{ _permissions = value;OnPropertyChanged();} } 
        [JsonProperty("budget_id")]
        [ForeignKey(nameof(Budget))]
        public Guid BudgetId { get => _budgetid ; set{ _budgetid = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public CatalogBudget Budget { get => _budget ; set{ _budget = value;OnPropertyChanged();} } 

#region fields
        private CatalogBudget _budget ;
        private Guid _budgetid ;
        private User _user ;
        private Guid _userid ;
        private int _permissions ;
#endregion
    }
    public class UserSetting : Entity
    {
        [JsonProperty("user_id")]
        [ForeignKey(nameof(User))]
        public Guid UserId { get => _userid ; set{ _userid = value;OnPropertyChanged();} } 
        [JsonProperty("user")]
        public User User { get => _user ; set{ _user = value;OnPropertyChanged();} } 
        [JsonProperty("setting_value")]
        public string SettingValue { get => _settingvalue ; set{ _settingvalue = value;OnPropertyChanged();} } 
        [JsonProperty("setting_name")]
        public string SettingName { get => _settingname ; set{ _settingname = value;OnPropertyChanged();} } 

#region fields
        private string _settingname ;
        private User _user ;
        private Guid _userid ;
        private string _settingvalue ;
#endregion
    }
}
