﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.Configuration;
using Steeltoe.Management.Endpoint.Security;
using Steeltoe.Management.Endpoint.Test;
using System;
using Xunit;

namespace Steeltoe.Management.Endpoint.Env.Test
{
    public class EnvOptionsTest : BaseTest
    {
        [Fact]
        public void Constructor_InitializesWithDefaults()
        {
            var opts = new EnvEndpointOptions();
            Assert.Equal("env", opts.Id);

            Assert.Equal(new string[] { "password", "secret", "key", "token", ".*credentials.*", "vcap_services" }, opts.KeysToSanitize);
            Assert.Equal(Permissions.RESTRICTED, opts.RequiredPermissions);
        }

        [Fact]
        public void Constructor_ThrowsIfConfigNull()
        {
            IConfiguration config = null;
            Assert.Throws<ArgumentNullException>(() => new EnvEndpointOptions(config));
        }
    }
}
