// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;
using System.Security;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        internal const uint CRYPTPROTECTMEMORY_BLOCK_SIZE = 16;
        internal const uint CRYPTPROTECTMEMORY_SAME_PROCESS = 0;

        [DllImport(Libraries.Crypt32, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool CryptProtectMemory(SafeBuffer pData, uint cbData, uint dwFlags);

        [DllImport(Libraries.Crypt32, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool CryptUnprotectMemory(SafeBuffer pData, uint cbData, uint dwFlags);
    }
}
