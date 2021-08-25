﻿using System.Collections.Generic;
using System.Linq.Expressions;
using Laraue.EfCoreTriggers.Common.SqlGeneration;
using Laraue.EfCoreTriggers.Common.TriggerBuilders;

namespace Laraue.EfCoreTriggers.Common.Converters.MethodCall.String.Trim
{
    public abstract class BaseStringTrimConverter : BaseStringConverter
    {
        public abstract string TrimsTypeName { get; }
        /// <inheritdoc />
        public override string MethodName => nameof(string.Trim);

        /// <inheritdoc />
        public override SqlBuilder BuildSql(BaseExpressionProvider provider, MethodCallExpression expression, Dictionary<string, ArgumentType> argumentTypes)
        {
            var sqlBuilder = provider.GetExpressionSql(expression.Object, argumentTypes);
            return new(sqlBuilder.AffectedColumns, $"{TrimsTypeName}({sqlBuilder})");
        }
    }
}