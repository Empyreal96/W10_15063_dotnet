// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccount2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [Guid(955592476, 4406, 16983, 149, 159, 182, 88, 163, 82, 182, 212)]
  [ExclusiveTo(typeof (MobileBroadbandAccount))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandAccount2
  {
    IVectorView<ConnectionProfile> GetConnectionProfiles();
  }
}
