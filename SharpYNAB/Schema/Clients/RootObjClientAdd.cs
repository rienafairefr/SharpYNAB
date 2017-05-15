using System.Linq;

namespace SharpYNAB.Schema.Clients
{
    public partial class BudgetClient{
        public new void ResetChanged()
        {
            base.ResetChanged();
            ResetChanged(Changed.Transactions, Obj.Transactions);
            ResetChanged(Changed.MasterCategories, Obj.MasterCategories);
            ResetChanged(Changed.Settings, Obj.Settings);
            ResetChanged(Changed.MonthlyBudgetCalculations, Obj.MonthlyBudgetCalculations);
            ResetChanged(Changed.AccountMappings, Obj.AccountMappings);
            ResetChanged(Changed.Subtransactions, Obj.Subtransactions);
            ResetChanged(Changed.ScheduledSubtransactions, Obj.ScheduledSubtransactions);
            ResetChanged(Changed.MonthlyBudgets, Obj.MonthlyBudgets);
            ResetChanged(Changed.Subcategories, Obj.Subcategories);
            ResetChanged(Changed.PayeeLocations, Obj.PayeeLocations);
            ResetChanged(Changed.AccountCalculations, Obj.AccountCalculations);
            ResetChanged(Changed.MonthlyAccountCalculations, Obj.MonthlyAccountCalculations);
            ResetChanged(Changed.MonthlySubcategoryBudgetCalculations, Obj.MonthlySubcategoryBudgetCalculations);
            ResetChanged(Changed.ScheduledTransactions, Obj.ScheduledTransactions);
            ResetChanged(Changed.Payees, Obj.Payees);
            ResetChanged(Changed.MonthlySubcategoryBudgets, Obj.MonthlySubcategoryBudgets);
            ResetChanged(Changed.PayeeRenameConditions, Obj.PayeeRenameConditions);
            ResetChanged(Changed.Accounts, Obj.Accounts);
        }

        public override void UpdateFromChangedEntities(Roots.Budget changedEntities)
        {
            foreach (var obj in changedEntities.Transactions)
            {
                var currentObj = Obj.Transactions.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Transactions.Remove(currentObj);
                    }
                }else{
                    Obj.Transactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MasterCategories)
            {
                var currentObj = Obj.MasterCategories.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.MasterCategories.Remove(currentObj);
                    }
                }else{
                    Obj.MasterCategories.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Settings)
            {
                var currentObj = Obj.Settings.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Settings.Remove(currentObj);
                    }
                }else{
                    Obj.Settings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlyBudgetCalculations)
            {
                var currentObj = Obj.MonthlyBudgetCalculations.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.MonthlyBudgetCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlyBudgetCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.AccountMappings)
            {
                var currentObj = Obj.AccountMappings.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.AccountMappings.Remove(currentObj);
                    }
                }else{
                    Obj.AccountMappings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Subtransactions)
            {
                var currentObj = Obj.Subtransactions.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Subtransactions.Remove(currentObj);
                    }
                }else{
                    Obj.Subtransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ScheduledSubtransactions)
            {
                var currentObj = Obj.ScheduledSubtransactions.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.ScheduledSubtransactions.Remove(currentObj);
                    }
                }else{
                    Obj.ScheduledSubtransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlyBudgets)
            {
                var currentObj = Obj.MonthlyBudgets.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.MonthlyBudgets.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlyBudgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Subcategories)
            {
                var currentObj = Obj.Subcategories.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Subcategories.Remove(currentObj);
                    }
                }else{
                    Obj.Subcategories.Add(obj);
                }
            }
            foreach (var obj in changedEntities.PayeeLocations)
            {
                var currentObj = Obj.PayeeLocations.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.PayeeLocations.Remove(currentObj);
                    }
                }else{
                    Obj.PayeeLocations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.AccountCalculations)
            {
                var currentObj = Obj.AccountCalculations.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.AccountCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.AccountCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlyAccountCalculations)
            {
                var currentObj = Obj.MonthlyAccountCalculations.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.MonthlyAccountCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlyAccountCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlySubcategoryBudgetCalculations)
            {
                var currentObj = Obj.MonthlySubcategoryBudgetCalculations.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.MonthlySubcategoryBudgetCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlySubcategoryBudgetCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ScheduledTransactions)
            {
                var currentObj = Obj.ScheduledTransactions.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.ScheduledTransactions.Remove(currentObj);
                    }
                }else{
                    Obj.ScheduledTransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Payees)
            {
                var currentObj = Obj.Payees.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Payees.Remove(currentObj);
                    }
                }else{
                    Obj.Payees.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlySubcategoryBudgets)
            {
                var currentObj = Obj.MonthlySubcategoryBudgets.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.MonthlySubcategoryBudgets.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlySubcategoryBudgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.PayeeRenameConditions)
            {
                var currentObj = Obj.PayeeRenameConditions.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.PayeeRenameConditions.Remove(currentObj);
                    }
                }else{
                    Obj.PayeeRenameConditions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Accounts)
            {
                var currentObj = Obj.Accounts.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Accounts.Remove(currentObj);
                    }
                }else{
                    Obj.Accounts.Add(obj);
                }
            }
        }
    }
    public partial class CatalogClient{
        public new void ResetChanged()
        {
            base.ResetChanged();
            ResetChanged(Changed.UserBudgets, Obj.UserBudgets);
            ResetChanged(Changed.UserSettings, Obj.UserSettings);
            ResetChanged(Changed.BudgetVersions, Obj.BudgetVersions);
            ResetChanged(Changed.Users, Obj.Users);
            ResetChanged(Changed.Budgets, Obj.Budgets);
        }

        public override void UpdateFromChangedEntities(Roots.Catalog changedEntities)
        {
            foreach (var obj in changedEntities.UserBudgets)
            {
                var currentObj = Obj.UserBudgets.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.UserBudgets.Remove(currentObj);
                    }
                }else{
                    Obj.UserBudgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.UserSettings)
            {
                var currentObj = Obj.UserSettings.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.UserSettings.Remove(currentObj);
                    }
                }else{
                    Obj.UserSettings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.BudgetVersions)
            {
                var currentObj = Obj.BudgetVersions.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.BudgetVersions.Remove(currentObj);
                    }
                }else{
                    Obj.BudgetVersions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Users)
            {
                var currentObj = Obj.Users.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Users.Remove(currentObj);
                    }
                }else{
                    Obj.Users.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Budgets)
            {
                var currentObj = Obj.Budgets.FirstOrDefault(o=>o.Id == obj.Id);
                if (currentObj != null){
                    if (obj.IsTombstone){
                        Obj.Budgets.Remove(currentObj);
                    }
                }else{
                    Obj.Budgets.Add(obj);
                }
            }
        }
    }
}
