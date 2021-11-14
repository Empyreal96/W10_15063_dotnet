// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserBase
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.ComponentModel;
using System.Windows.Controls;

namespace Microsoft.Phone.Controls
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public abstract class WebBrowserBase : Control
  {
    internal WebBrowserBase()
    {
    }

    internal abstract double GetMinimumEditActivationHeight();

    internal abstract double GetNormalHeight();

    internal abstract void OnGotSipFocusFromYamanotePage(double bottomObscuredBySIP);

    internal abstract void OnLostSipFocusFromYamanotePage();
  }
}
