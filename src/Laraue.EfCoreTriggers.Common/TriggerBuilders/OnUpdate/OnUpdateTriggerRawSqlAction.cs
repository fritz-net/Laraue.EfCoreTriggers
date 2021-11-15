using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Laraue.EfCoreTriggers.Common.TriggerBuilders.Base;

namespace Laraue.EfCoreTriggers.Common.TriggerBuilders.OnUpdate
{
    public class OnUpdateTriggerRawSqlAction<TTriggerEntity> : TriggerRawSqlAction<TTriggerEntity>
        where TTriggerEntity : class
    {
        public OnUpdateTriggerRawSqlAction(string SqlStatement)
            : base (SqlStatement)
        {
        }
    }
}