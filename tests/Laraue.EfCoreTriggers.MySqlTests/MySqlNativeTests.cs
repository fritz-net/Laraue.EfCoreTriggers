﻿using Laraue.EfCoreTriggers.Tests.Tests;
using Xunit;

namespace Laraue.EfCoreTriggers.MySqlTests
{
    [Collection("MySqlNativeTests")]
    public class MySqlNativeTests : BaseNativeTests
    {
        public MySqlNativeTests() : base(new ContextFactory().CreateDbContext())
        {
        }
    }
}