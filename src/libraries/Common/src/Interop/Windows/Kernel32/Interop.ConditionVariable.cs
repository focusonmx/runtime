// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct CONDITION_VARIABLE
        {
            private IntPtr Ptr;
        }

        [DllImport(Libraries.Kernel32, ExactSpelling = true)]
        internal static extern unsafe void InitializeConditionVariable(CONDITION_VARIABLE* ConditionVariable);

        [DllImport(Libraries.Kernel32, ExactSpelling = true)]
        internal static extern unsafe void WakeConditionVariable(CONDITION_VARIABLE* ConditionVariable);

        [DllImport(Libraries.Kernel32, ExactSpelling = true)]
        internal static extern unsafe bool SleepConditionVariableCS(CONDITION_VARIABLE* ConditionVariable, CRITICAL_SECTION* CriticalSection, int dwMilliseconds);
    }
}
