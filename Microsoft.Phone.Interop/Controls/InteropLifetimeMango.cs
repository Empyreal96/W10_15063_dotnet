// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.InteropLifetimeMango
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Phone.Controls
{
  internal class InteropLifetimeMango : InteropLifetime
  {
    public InteropLifetimeMango(Control webBrowser, WebBrowserInteropCallbacks callbacks) => this.Interop = (IWebBrowserInterop) new WebBrowserInterop(webBrowser, callbacks);

    protected override void OnEnterVisualTree(Border presentationContainer) => presentationContainer.Child = (UIElement) this.Interop.GetPresentation();

    protected override void OnExitVisualTree()
    {
    }
  }
}
