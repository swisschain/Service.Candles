﻿using System.Collections.Generic;
using Candles.Client.Models.IsAlive;
using Microsoft.AspNetCore.Mvc;
using Swisschain.Sdk.Server.Common;

namespace Candles.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class IsAliveController : ControllerBase
    {
        [HttpGet]
        public IsAliveResponse Get()
        {
            var response = new IsAliveResponse
            {
                Name = ApplicationInformation.AppName,
                Version = ApplicationInformation.AppVersion,
                StartedAt = ApplicationInformation.StartedAt,
                Env = ApplicationEnvironment.Environment,
                HostName = ApplicationEnvironment.HostName,
                StateIndicators = new List<IsAliveResponse.StateIndicator>()
            };

            return response;
        }
    }
}
