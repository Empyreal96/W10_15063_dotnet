// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(937682197, 33460, 19796, 143, 217, 175, 38, 36, 179, 1, 28)]
  internal interface IMapManagerStatics
  {
    void ShowDownloadedMapsUI();

    void ShowMapsUpdateUI();
  }
}
