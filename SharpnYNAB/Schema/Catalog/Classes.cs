using System;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


// ReSharper disable InconsistentNaming


namespace SharpnYNAB.Schema.Catalog
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
        public DateFormat DateFormat { get => _dateformat ; set{ _dateformat = value;OnPropertyChanged();} } 
        [JsonProperty("currency_format")]
        public CurrencyFormat CurrencyFormat { get => _currencyformat ; set{ _currencyformat = value;OnPropertyChanged();} } 
        [JsonIgnore]
        public CatalogBudget Budget { get => _budget ; set{ _budget = value;OnPropertyChanged();} } 
        [JsonProperty("budget_id")]
        [ForeignKey(nameof(Budget))]
        public Guid BudgetId { get => _budgetid ; set{ _budgetid = value;OnPropertyChanged();} } 
        private DateFormat _dateformat ;
        private DateTime _lastaccessedon ;
        private CurrencyFormat _currencyformat ;
        private Guid _budgetid ;
        private CatalogBudget _budget ;
        private string _versionname ;
        private string _source ;
    }
    public class CatalogBudget : Entity
    {
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get => _createdat ; set{ _createdat = value;OnPropertyChanged();} } 
        [JsonProperty("budget_name")]
        public string BudgetName { get => _budgetname ; set{ _budgetname = value;OnPropertyChanged();} } 
        private string _budgetname ;
        private DateTime? _createdat ;
    }
    public class User : Entity
    {
        [JsonProperty("username")]
        public string Username { get => _username ; set{ _username = value;OnPropertyChanged();} } 
        [JsonProperty("trial_expires_on")]
        public Date TrialExpiresOn { get => _trialexpireson ; set{ _trialexpireson = value;OnPropertyChanged();} } 
        [JsonProperty("sign_in_count")]
        public int SignInCount { get => _signincount ; set{ _signincount = value;OnPropertyChanged();} } 
        [JsonProperty("is_subscribed")]
        public bool IsSubscribed { get => _issubscribed ; set{ _issubscribed = value;OnPropertyChanged();} } 
        [JsonProperty("feature_flags")]
        public List<string> FeatureFlags { get => _featureflags ; set{ _featureflags = value;OnPropertyChanged();} } 
        [JsonProperty("email")]
        public string Email { get => _email ; set{ _email = value;OnPropertyChanged();} } 
        private string _username ;
        private Date _trialexpireson ;
        private string _email ;
        private List<string> _featureflags ;
        private int _signincount ;
        private bool _issubscribed ;
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
        private CatalogBudget _budget ;
        private Guid _budgetid ;
        private User _user ;
        private Guid _userid ;
        private int _permissions ;
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
        private string _settingname ;
        private User _user ;
        private Guid _userid ;
        private string _settingvalue ;
    }
}
