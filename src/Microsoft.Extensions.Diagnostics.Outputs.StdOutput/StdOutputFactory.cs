﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Validation;

namespace Microsoft.Extensions.Diagnostics.Outputs
{
    public class StdOutputFactory : IPipelineItemFactory<StdSender>
    {
        public StdSender CreateItem(IConfiguration configuration, IHealthReporter healthReporter)
        {
            Requires.NotNull(healthReporter, nameof(healthReporter));

            return new StdSender(healthReporter);
        }
    }
}
