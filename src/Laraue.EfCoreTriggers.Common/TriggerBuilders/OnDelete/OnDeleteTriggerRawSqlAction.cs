using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Laraue.EfCoreTriggers.Common.TriggerBuilders.Base;

namespace Laraue.EfCoreTriggers.Common.TriggerBuilders.OnDelete
{
    public class OnDeleteTriggerRawSqlAction<TTriggerEntity> : TriggerRawSqlAction<TTriggerEntity>
        where TTriggerEntity : class
    {
        public OnDeleteTriggerRawSqlAction(string SqlStatement)
            : base(SqlStatement)
        {
        }
    }
}