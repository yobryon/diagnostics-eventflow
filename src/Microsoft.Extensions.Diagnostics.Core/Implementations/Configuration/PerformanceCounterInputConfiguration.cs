﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Extensions.Diagnostics.Configuration
{
    public class PerformanceCounterInputConfiguration: ItemConfiguration
    {
        public List<PerformanceCounterConfiguration> Counters { get; set; }
    }
}
