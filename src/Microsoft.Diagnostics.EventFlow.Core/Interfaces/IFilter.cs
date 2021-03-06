﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Diagnostics.EventFlow
{
    public enum FilterResult
    {
        KeepEvent = 0,
        DiscardEvent = 1
    }

    public interface IFilter
    {
        FilterResult Evaluate(EventData eventData);
    }
}
