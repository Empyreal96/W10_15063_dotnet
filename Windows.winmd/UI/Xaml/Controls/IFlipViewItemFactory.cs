// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlipViewItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4062024190, 8864, 17426, 168, 83, 157, 106, 110, 143, 42, 175)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FlipViewItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFlipViewItemFactory
  {
    FlipViewItem CreateInstance(object outer, out object inner);
  }
}
