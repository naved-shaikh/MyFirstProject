﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Application.Startup))]
namespace Test_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
