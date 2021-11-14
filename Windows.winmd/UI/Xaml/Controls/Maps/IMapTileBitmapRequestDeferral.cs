// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileBitmapRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(4265018690, 42156, 20218, 150, 101, 4, 144, 176, 202, 253, 210)]
  [ExclusiveTo(typeof (MapTileBitmapRequestDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapTileBitmapRequestDeferral
  {
    void Complete();
  }
}
