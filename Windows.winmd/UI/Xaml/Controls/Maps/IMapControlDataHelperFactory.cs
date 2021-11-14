// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlDataHelperFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControlDataHelper))]
  [ContractVersion(typeof (LocalSearchContract), 131072)]
  [Guid(997239438, 751, 18076, 187, 175, 220, 33, 88, 212, 40, 155)]
  [WebHostHidden]
  internal interface IMapControlDataHelperFactory
  {
    MapControlDataHelper CreateInstance(MapControl map);
  }
}
