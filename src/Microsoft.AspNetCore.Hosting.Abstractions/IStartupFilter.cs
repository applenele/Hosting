// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Builder;

namespace Microsoft.AspNetCore.Hosting
{
    /// ʵ����IStartupFilter�ӿڵ��࣬ʵ����Ҳ�����ܵ���ע���м��
    /// ��StartupΨһ���������ڣ�ʵ����IStartupFilter���м������Startup����ע����м��֮ǰִ��
    /// ԭ����ڴ˴�������
    /// ��ϸӦ�òο� https://www.cnblogs.com/artech/p/asp-net-core-real-pipeline-05.html
    public interface IStartupFilter
    {
        Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next);
    }
}
