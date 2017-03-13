﻿using Domain.Logging;
using Nancy;
using Nancy.Security;

namespace Infrastructure.Web.Modules
{
    // check https://octopus.com/docs/api-and-integration/octopus.client
    public class DeployModule : NancyModule
    {
        public DeployModule(ILogger logger) : base("/deploys")
        {
            this.RequiresAuthentication();

            Get["/"] = parameters => "Hello World";
        }
    }
}