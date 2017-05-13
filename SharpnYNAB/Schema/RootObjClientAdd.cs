using System.Collections.Generic;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Catalog;
using System.Linq;

namespace SharpnYNAB.Schema
{
    public partial class BudgetClient{
        public override void UpdateFromChangedEntities(Roots.Budget changedEntities)
        {
            foreach (var obj in changedEntities.Transactions)
            {
                var currentObj = Obj.Transactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Transactions.Remove(currentObj);
                    }
                }else{
                    Obj.Transactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MasterCategories)
            {
                var currentObj = Obj.MasterCategories.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.MasterCategories.Remove(currentObj);
                    }
                }else{
                    Obj.MasterCategories.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Settings)
            {
                var currentObj = Obj.Settings.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Settings.Remove(currentObj);
                    }
                }else{
                    Obj.Settings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlyBudgetCalculations)
            {
                var currentObj = Obj.MonthlyBudgetCalculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.MonthlyBudgetCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlyBudgetCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.AccountMappings)
            {
                var currentObj = Obj.AccountMappings.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.AccountMappings.Remove(currentObj);
                    }
                }else{
                    Obj.AccountMappings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Subtransactions)
            {
                var currentObj = Obj.Subtransactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Subtransactions.Remove(currentObj);
                    }
                }else{
                    Obj.Subtransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ScheduledSubtransactions)
            {
                var currentObj = Obj.ScheduledSubtransactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.ScheduledSubtransactions.Remove(currentObj);
                    }
                }else{
                    Obj.ScheduledSubtransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlyBudgets)
            {
                var currentObj = Obj.MonthlyBudgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.MonthlyBudgets.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlyBudgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Subcategories)
            {
                var currentObj = Obj.Subcategories.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Subcategories.Remove(currentObj);
                    }
                }else{
                    Obj.Subcategories.Add(obj);
                }
            }
            foreach (var obj in changedEntities.PayeeLocations)
            {
                var currentObj = Obj.PayeeLocations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.PayeeLocations.Remove(currentObj);
                    }
                }else{
                    Obj.PayeeLocations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.AccountCalculations)
            {
                var currentObj = Obj.AccountCalculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.AccountCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.AccountCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlyAccountCalculations)
            {
                var currentObj = Obj.MonthlyAccountCalculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.MonthlyAccountCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlyAccountCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlySubcategoryBudgetCalculations)
            {
                var currentObj = Obj.MonthlySubcategoryBudgetCalculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.MonthlySubcategoryBudgetCalculations.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlySubcategoryBudgetCalculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ScheduledTransactions)
            {
                var currentObj = Obj.ScheduledTransactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.ScheduledTransactions.Remove(currentObj);
                    }
                }else{
                    Obj.ScheduledTransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Payees)
            {
                var currentObj = Obj.Payees.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Payees.Remove(currentObj);
                    }
                }else{
                    Obj.Payees.Add(obj);
                }
            }
            foreach (var obj in changedEntities.MonthlySubcategoryBudgets)
            {
                var currentObj = Obj.MonthlySubcategoryBudgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.MonthlySubcategoryBudgets.Remove(currentObj);
                    }
                }else{
                    Obj.MonthlySubcategoryBudgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.PayeeRenameConditions)
            {
                var currentObj = Obj.PayeeRenameConditions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.PayeeRenameConditions.Remove(currentObj);
                    }
                }else{
                    Obj.PayeeRenameConditions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Accounts)
            {
                var currentObj = Obj.Accounts.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Accounts.Remove(currentObj);
                    }
                }else{
                    Obj.Accounts.Add(obj);
                }
            }
        }
    }
    public partial class CatalogClient{
        public override void UpdateFromChangedEntities(Roots.Catalog changedEntities)
        {
            foreach (var obj in changedEntities.UserBudgets)
            {
                var currentObj = Obj.UserBudgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.UserBudgets.Remove(currentObj);
                    }
                }else{
                    Obj.UserBudgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.UserSettings)
            {
                var currentObj = Obj.UserSettings.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.UserSettings.Remove(currentObj);
                    }
                }else{
                    Obj.UserSettings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.BudgetVersions)
            {
                var currentObj = Obj.BudgetVersions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.BudgetVersions.Remove(currentObj);
                    }
                }else{
                    Obj.BudgetVersions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Users)
            {
                var currentObj = Obj.Users.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Users.Remove(currentObj);
                    }
                }else{
                    Obj.Users.Add(obj);
                }
            }
            foreach (var obj in changedEntities.Budgets)
            {
                var currentObj = Obj.Budgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.Budgets.Remove(currentObj);
                    }
                }else{
                    Obj.Budgets.Add(obj);
                }
            }
        }
    }
}
