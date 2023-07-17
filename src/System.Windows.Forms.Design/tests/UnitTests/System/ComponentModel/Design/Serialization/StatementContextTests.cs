﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design.Serialization.Tests;

public class StatementContextTests
{
    [Fact]
    public void StatementContext_Ctor_Default()
    {
        StatementContext context = new();
        Assert.Empty(context.StatementCollection);
        Assert.Same(context.StatementCollection, context.StatementCollection);
    }
}
