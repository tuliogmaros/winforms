﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Windows.Forms;

public sealed partial class Application
{
    /// <summary>
    ///  This class allows us to handle sends/posts in our winformssynchcontext on the correct thread via
    ///  control.invoke().
    /// </summary>
    internal sealed class MarshalingControl : Control
    {
        internal MarshalingControl()
            : base(false)
        {
            Visible = false;
            SetExtendedState(ExtendedStates.InterestedInUserPreferenceChanged, false);
            SetTopLevel(true);
            CreateControl();
            CreateHandle();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // Message only windows are cheaper and have fewer issues than full blown invisible windows.
                cp.Parent = HWND.HWND_MESSAGE;
                return cp;
            }
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            // Don't do anything here -- small perf game of avoiding layout, etc.
        }
    }
}
