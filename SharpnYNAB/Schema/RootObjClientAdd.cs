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
