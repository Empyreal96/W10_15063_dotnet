// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.InteropLifetime7
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Phone.Controls
{
  internal class InteropLifetime7 : InteropLifetime
  {
    private Control webBrowser;
    private WebBrowserInteropCallbacks callbacks;
    private GetCachedWebBrowserPropertiesCallback propertiesCallback;

    public InteropLifetime7(
      Control webBrowser,
      WebBrowserInteropCallbacks callbacks,
      GetCachedWebBrowserPropertiesCallback propertiesCallback)
    {
      this.webBrowser = webBrowser;
      this.callbacks = callbacks;
      this.propertiesCallback = propertiesCallback;
      this.Interop = (IWebBrowserInterop) new WebBrowserDisconnected();
    }

    protected override void OnEnterVisualTree(Border presentationContainer)
    {
      this.Interop.Suppress();
      WebBrowserInterop webBrowserInterop = new WebBrowserInterop(this.webBrowser, this.callbacks);
      presentationContainer.Child = (UIElement) webBrowserInterop.GetPresentation();
      bool isScriptEnabledVal;
      string baseVal;
      Uri sourceVal;
      this.propertiesCallback(out isScriptEnabledVal, out baseVal, out sourceVal);
      if (isScriptEnabledVal)
        webBrowserInterop.IsScriptEnabled = isScriptEnabledVal;
      if (!string.IsNullOrEmpty(baseVal))
        webBrowserInterop.Base = baseVal;
      if (sourceVal != (Uri) null)
        webBrowserInterop.Source = sourceVal;
      this.Interop = (IWebBrowserInterop) webBrowserInterop;
    }

    protected override void OnExitVisualTree()
    {
      this.Interop.Suppress();
      this.Interop = (IWebBrowserInterop) new WebBrowserDisconnected();
    }
  }
}
