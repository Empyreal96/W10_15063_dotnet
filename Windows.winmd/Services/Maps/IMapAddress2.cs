// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapAddress2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapAddress))]
  [Guid(1976397297, 58797, 17833, 191, 64, 108, 242, 86, 193, 221, 19)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapAddress2
  {
    string FormattedAddress { get; }
  }
}
