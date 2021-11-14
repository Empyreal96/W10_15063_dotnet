// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlyoutFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1273841971, 142, 19203, 163, 133, 121, 254, 82, 102, 221, 186)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Flyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFlyoutFactory
  {
    Flyout CreateInstance(object outer, out object inner);
  }
}
