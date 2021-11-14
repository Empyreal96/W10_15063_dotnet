// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPanelFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Panel))]
  [Guid(4008083729, 51148, 17215, 149, 205, 214, 48, 195, 67, 2, 221)]
  [WebHostHidden]
  internal interface IPanelFactory
  {
    Panel CreateInstance(object outer, out object inner);
  }
}
