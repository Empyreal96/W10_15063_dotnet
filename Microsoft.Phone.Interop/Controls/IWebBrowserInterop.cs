// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.IWebBrowserInterop
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Windows;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  internal interface IWebBrowserInterop
  {
    void NavigateCustom(Uri uri, byte[] postData, string pszHeaders);

    void NavigateToString(string pszHtml);

    void NavigateBack();

    void NavigateForward();

    string SaveToString();

    object InvokeScript(string scriptName, params string[] args);

    void SetBackgroundColor(Color color);

    Uri Source { get; set; }

    string Base { get; set; }

    bool IsScriptEnabled { get; set; }

    bool IsGeolocationEnabled { get; set; }

    void Suppress();

    FrameworkElement GetPresentation();

    void LoseFocus(bool hideSIP);

    void DoPendingEditActivation();

    void BounceViewportToBounds();

    void UpdateOrientation(int rotationAngle);

    void Copy();

    void Paste();

    void GetWebBrowserUiaProvider(IntPtr windowlessSite, ref IntPtr provider);
  }
}
