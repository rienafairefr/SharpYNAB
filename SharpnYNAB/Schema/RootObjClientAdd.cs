using System.Collections.Generic;
using Newtonsoft.Json;
using SharpnYNAB.Schema.Budget;
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
        }
    }
}
