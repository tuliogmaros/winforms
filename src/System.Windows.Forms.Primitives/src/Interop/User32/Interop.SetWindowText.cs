﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class User32
    {
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode)]
        public static extern int SetWindowTextW(IntPtr hWnd, string text);

        public static int SetWindowTextW(IHandle hWnd, string text)
        {
            int result = SetWindowTextW(hWnd.Handle, text);
            GC.KeepAlive(hWnd);
            return result;
        }
    }
}