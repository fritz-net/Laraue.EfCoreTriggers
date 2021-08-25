﻿using Laraue.EfCoreTriggers.Common.SqlGeneration;
using Laraue.EfCoreTriggers.Common.TriggerBuilders;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Laraue.EfCoreTriggers.Common.Converters.MethodCall.Math.Atan
{
    public class MathAtanConverter : BaseMathConverter
    {
        public override string MethodName => nameof(System.Math.Atan);

        public override SqlBuilder BuildSql(BaseExpressionProvider provider, MethodCallExpression expression, Dictionary<string, ArgumentType> argumentTypes)
        {
            var argument = expression.Arguments[0];
            var sqlBuilder = provider.GetExpressionSql(argument, argumentTypes);
            return new SqlBuilder(sqlBuilder.AffectedColumns, $"ATAN({sqlBuilder})");
        }
    }
}
