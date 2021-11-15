using System.Collections.Generic;
using System.Linq.Expressions;
using Laraue.EfCoreTriggers.Common.SqlGeneration;

namespace Laraue.EfCoreTriggers.Common.TriggerBuilders.Base
{
    public abstract class TriggerRawSqlAction<TTriggerEntity> : ITriggerAction
       where TTriggerEntity : class
    {
        internal string SqlStatement;

        public TriggerRawSqlAction(string sqlStatement)
        {
            this.SqlStatement = sqlStatement;
        }

        public virtual SqlBuilder BuildSql(ITriggerProvider visitor)
            => visitor.GetTriggerRawSqlActionSql(this);
    }
}