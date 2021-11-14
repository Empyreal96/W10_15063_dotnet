// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandUicc
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandUicc))]
  [Guid(3862230673, 21082, 19682, 143, 206, 170, 65, 98, 87, 145, 84)]
  internal interface IMobileBroadbandUicc
  {
    string SimIccId { get; }

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandUiccAppsResult> GetUiccAppsAsync();
  }
}
