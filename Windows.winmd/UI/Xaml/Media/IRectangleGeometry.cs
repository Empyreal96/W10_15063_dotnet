// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRectangleGeometry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2723815256, 50549, 16790, 145, 207, 159, 223, 177, 4, 69, 195)]
  [ExclusiveTo(typeof (RectangleGeometry))]
  internal interface IRectangleGeometry
  {
    Rect Rect { get; set; }
  }
}
