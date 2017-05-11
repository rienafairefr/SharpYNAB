using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Budget;
using SharpnYNAB.Schema.Catalog;
using System.Linq;

namespace SharpnYNAB.Schema
{
    public partial class BudgetClient{
        public override void UpdateFromChangedEntities(Roots.Budget changedEntities)
        {
            foreach (var obj in changedEntities.be_transactions)
            {
                var currentObj = Obj.be_transactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_transactions.Remove(currentObj);
                    }
                }else{
                    Obj.be_transactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_master_categories)
            {
                var currentObj = Obj.be_master_categories.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_master_categories.Remove(currentObj);
                    }
                }else{
                    Obj.be_master_categories.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_settings)
            {
                var currentObj = Obj.be_settings.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_settings.Remove(currentObj);
                    }
                }else{
                    Obj.be_settings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_monthly_budget_calculations)
            {
                var currentObj = Obj.be_monthly_budget_calculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_monthly_budget_calculations.Remove(currentObj);
                    }
                }else{
                    Obj.be_monthly_budget_calculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_account_mappings)
            {
                var currentObj = Obj.be_account_mappings.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_account_mappings.Remove(currentObj);
                    }
                }else{
                    Obj.be_account_mappings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_subtransactions)
            {
                var currentObj = Obj.be_subtransactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_subtransactions.Remove(currentObj);
                    }
                }else{
                    Obj.be_subtransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_scheduled_subtransactions)
            {
                var currentObj = Obj.be_scheduled_subtransactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_scheduled_subtransactions.Remove(currentObj);
                    }
                }else{
                    Obj.be_scheduled_subtransactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_monthly_budgets)
            {
                var currentObj = Obj.be_monthly_budgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_monthly_budgets.Remove(currentObj);
                    }
                }else{
                    Obj.be_monthly_budgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_subcategories)
            {
                var currentObj = Obj.be_subcategories.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_subcategories.Remove(currentObj);
                    }
                }else{
                    Obj.be_subcategories.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_payee_locations)
            {
                var currentObj = Obj.be_payee_locations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_payee_locations.Remove(currentObj);
                    }
                }else{
                    Obj.be_payee_locations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_account_calculations)
            {
                var currentObj = Obj.be_account_calculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_account_calculations.Remove(currentObj);
                    }
                }else{
                    Obj.be_account_calculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_monthly_account_calculations)
            {
                var currentObj = Obj.be_monthly_account_calculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_monthly_account_calculations.Remove(currentObj);
                    }
                }else{
                    Obj.be_monthly_account_calculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_monthly_subcategory_budget_calculations)
            {
                var currentObj = Obj.be_monthly_subcategory_budget_calculations.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_monthly_subcategory_budget_calculations.Remove(currentObj);
                    }
                }else{
                    Obj.be_monthly_subcategory_budget_calculations.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_scheduled_transactions)
            {
                var currentObj = Obj.be_scheduled_transactions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_scheduled_transactions.Remove(currentObj);
                    }
                }else{
                    Obj.be_scheduled_transactions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_payees)
            {
                var currentObj = Obj.be_payees.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_payees.Remove(currentObj);
                    }
                }else{
                    Obj.be_payees.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_monthly_subcategory_budgets)
            {
                var currentObj = Obj.be_monthly_subcategory_budgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_monthly_subcategory_budgets.Remove(currentObj);
                    }
                }else{
                    Obj.be_monthly_subcategory_budgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_payee_rename_conditions)
            {
                var currentObj = Obj.be_payee_rename_conditions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_payee_rename_conditions.Remove(currentObj);
                    }
                }else{
                    Obj.be_payee_rename_conditions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.be_accounts)
            {
                var currentObj = Obj.be_accounts.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.be_accounts.Remove(currentObj);
                    }
                }else{
                    Obj.be_accounts.Add(obj);
                }
            }
        }
    }
    public partial class CatalogClient{
        public override void UpdateFromChangedEntities(Roots.Catalog changedEntities)
        {
            foreach (var obj in changedEntities.ce_user_budgets)
            {
                var currentObj = Obj.ce_user_budgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.ce_user_budgets.Remove(currentObj);
                    }
                }else{
                    Obj.ce_user_budgets.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ce_user_settings)
            {
                var currentObj = Obj.ce_user_settings.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.ce_user_settings.Remove(currentObj);
                    }
                }else{
                    Obj.ce_user_settings.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ce_budget_versions)
            {
                var currentObj = Obj.ce_budget_versions.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.ce_budget_versions.Remove(currentObj);
                    }
                }else{
                    Obj.ce_budget_versions.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ce_users)
            {
                var currentObj = Obj.ce_users.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.ce_users.Remove(currentObj);
                    }
                }else{
                    Obj.ce_users.Add(obj);
                }
            }
            foreach (var obj in changedEntities.ce_budgets)
            {
                var currentObj = Obj.ce_budgets.FirstOrDefault(o=>o.id == obj.id);
                if (currentObj != null){
                    if (obj.is_tombstone){
                        Obj.ce_budgets.Remove(currentObj);
                    }
                }else{
                    Obj.ce_budgets.Add(obj);
                }
            }
        }
    }
}
