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
        public string version_name { get => _versionname ; set{ _versionname = value;OnPropertyChanged();} } 
        public string source { get => _source ; set{ _source = value;OnPropertyChanged();} } 
        public DateTime last_accessed_on { get => _lastaccessedon ; set{ _lastaccessedon = value;OnPropertyChanged();} } 
        public DateFormat date_format { get => _dateformat ; set{ _dateformat = value;OnPropertyChanged();} } 
        public CurrencyFormat currency_format { get => _currencyformat ; set{ _currencyformat = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public CatalogBudget budget { get => _budget ; set{ _budget = value;OnPropertyChanged();} } 
        public Guid budget_id { get => _budgetid ; set{ _budgetid = value;OnPropertyChanged();} } 
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
        public DateTime? created_at { get => _createdat ; set{ _createdat = value;OnPropertyChanged();} } 
        public string budget_name { get => _budgetname ; set{ _budgetname = value;OnPropertyChanged();} } 
        private string _budgetname ;
        private DateTime? _createdat ;
    }
    public class User : Entity
    {
        public string username { get => _username ; set{ _username = value;OnPropertyChanged();} } 
        public Date trial_expires_on { get => _trialexpireson ; set{ _trialexpireson = value;OnPropertyChanged();} } 
        public int sign_in_count { get => _signincount ; set{ _signincount = value;OnPropertyChanged();} } 
        public bool is_subscribed { get => _issubscribed ; set{ _issubscribed = value;OnPropertyChanged();} } 
        public List<string> feature_flags { get => _featureflags ; set{ _featureflags = value;OnPropertyChanged();} } 
        public string email { get => _email ; set{ _email = value;OnPropertyChanged();} } 
        private string _username ;
        private Date _trialexpireson ;
        private string _email ;
        private List<string> _featureflags ;
        private int _signincount ;
        private bool _issubscribed ;
    }
    public class UserBudget : Entity
    {
        public Guid user_id { get => _userid ; set{ _userid = value;OnPropertyChanged();} } 

        [JsonIgnore]
        public User user { get => _user ; set{ _user = value;OnPropertyChanged();} } 
        public int permissions { get => _permissions ; set{ _permissions = value;OnPropertyChanged();} } 
        public Guid budget_id { get => _budgetid ; set{ _budgetid = value;OnPropertyChanged();} } 
        private Guid _budgetid ;
        private User _user ;
        private Guid _userid ;
        private int _permissions ;
    }
    public class UserSetting : Entity
    {
        public Guid user_id { get => _userid ; set{ _userid = value;OnPropertyChanged();} } 
        public User user { get => _user ; set{ _user = value;OnPropertyChanged();} } 
        public string setting_value { get => _settingvalue ; set{ _settingvalue = value;OnPropertyChanged();} } 
        public string setting_name { get => _settingname ; set{ _settingname = value;OnPropertyChanged();} } 
        private string _settingname ;
        private User _user ;
        private Guid _userid ;
        private string _settingvalue ;
    }
}
