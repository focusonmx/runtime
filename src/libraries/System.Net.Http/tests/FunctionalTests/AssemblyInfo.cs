// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Xunit;

[assembly: SkipOnCoreClr("System.Net.Tests are flaky and/or long running: https://github.com/dotnet/runtime/issues/131", RuntimeConfiguration.Checked)]
[assembly: ActiveIssue("https://github.com/dotnet/runtime/issues/131", typeof(PlatformDetection), nameof(PlatformDetection.IsMonoRuntime), nameof(PlatformDetection.IsNotBrowser))] // System.Net.Tests are flaky and/or long running

