// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccountStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandAccount))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2860469540, 44993, 20424, 174, 154, 169, 23, 83, 16, 250, 173)]
  internal interface IMobileBroadbandAccountStatics
  {
    IVectorView<string> AvailableNetworkAccountIds { get; }

    MobileBroadbandAccount CreateFromNetworkAccountId(string networkAccountId);
  }
}
