// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapServiceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapService))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(21278085, 49228, 19677, 135, 26, 160, 114, 109, 9, 124, 212)]
  internal interface IMapServiceStatics
  {
    string ServiceToken { set; get; }
  }
}
