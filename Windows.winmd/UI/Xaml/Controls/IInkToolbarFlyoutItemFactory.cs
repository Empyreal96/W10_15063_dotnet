// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarFlyoutItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(892238739, 32827, 20238, 140, 114, 157, 252, 3, 41, 50, 159)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbarFlyoutItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkToolbarFlyoutItemFactory
  {
    InkToolbarFlyoutItem CreateInstance(object outer, out object inner);
  }
}
