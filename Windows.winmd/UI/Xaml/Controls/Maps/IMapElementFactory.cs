// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Guid(1244712967, 3030, 18341, 134, 11, 126, 124, 245, 240, 197, 115)]
  [ExclusiveTo(typeof (MapElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapElementFactory
  {
    MapElement CreateInstance(object outer, out object inner);
  }
}
