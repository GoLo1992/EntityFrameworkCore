﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public class EagerLoadingExpressionVisitorFactory : IEagerLoadingExpressionVisitorFactory
    {
        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public EagerLoadingExpressionVisitor Create(
            QueryCompilationContext queryCompilationContext,
            IQuerySourceTracingExpressionVisitorFactory querySourceTracingExpressionVisitorFactory)
            => new EagerLoadingExpressionVisitor(queryCompilationContext, querySourceTracingExpressionVisitorFactory);
    }
}
