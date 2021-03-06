﻿using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Acesoft
{
    public abstract class StartupBase : IStartup
    {
        /// <inheritdoc />
        public virtual int Order { get; } = 0;
        public object Tenant { get; protected set; }

        public IStartup SetTenant(object tenant)
        {
            Tenant = tenant;
            return this;
        }

        /// <inheritdoc />
        public virtual void ConfigureServices(IServiceCollection services)
        {
        }

        /// <inheritdoc />
        public virtual void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider services)
        {
        }
    }
}