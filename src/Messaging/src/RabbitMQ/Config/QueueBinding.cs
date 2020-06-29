﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Steeltoe.Messaging.Rabbit.Config
{
    public class QueueBinding : Binding
    {
        public QueueBinding(string name, string queueDestination, string exchange, string routingKey, Dictionary<string, object> arguments)
            : base(name, queueDestination, DestinationType.QUEUE, exchange, routingKey, arguments)
        {
        }
    }
}