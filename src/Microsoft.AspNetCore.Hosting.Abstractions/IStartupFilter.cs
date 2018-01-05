// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;

namespace Microsoft.AspNetCore.Hosting
{
    /// 实现了IStartupFilter接口的类，实际上也是往管道上注册中间件
    /// 与Startup唯一的区别在于，实现了IStartupFilter的中间件会在Startup里面注册的中间件之前执行
    /// 原理就在此处代码中
    /// 详细应用参看 https://www.cnblogs.com/artech/p/asp-net-core-real-pipeline-05.html
    public interface IStartupFilter
    {
        Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next);
    }
}
