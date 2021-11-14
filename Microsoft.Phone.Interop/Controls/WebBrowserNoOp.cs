// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserNoOp
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Windows;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  internal class WebBrowserNoOp : IWebBrowserInterop
  {
    public virtual void Suppress()
    {
    }

    public virtual FrameworkElement GetPresentation() => (FrameworkElement) null;

    public virtual void NavigateCustom(Uri uri, byte[] postData, string pszHeaders)
    {
    }

    public virtual void NavigateToString(string pszHtml)
    {
    }

    public virtual void NavigateBack()
    {
    }

    public virtual void NavigateForward()
    {
    }

    public void GetWebBrowserUiaProvider(IntPtr windowlessSite, ref IntPtr provider)
    {
    }

    public virtual string SaveToString() => (string) null;

    public virtual object InvokeScript(string scriptName, params string[] args) => (object) null;

    public virtual void Suspend()
    {
    }

    public virtual void Resume()
    {
    }

    public virtual void LoseFocus(bool hideSIP)
    {
    }

    public virtual void DoPendingEditActivation()
    {
    }

    public virtual void BounceViewportToBounds()
    {
    }

    public virtual void UpdateOrientation(int rotationAngle)
    {
    }

    public virtual void Copy()
    {
    }

    public virtual void Paste()
    {
    }

    public virtual void SetBackgroundColor(Color color)
    {
    }

    public Uri Source { get; set; }

    public string Base { get; set; }

    public bool IsScriptEnabled { get; set; }

    public bool IsGeolocationEnabled { get; set; }
  }
}
