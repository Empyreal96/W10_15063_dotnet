// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandModemConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandModemConfiguration))]
  [Guid(4242552227, 54989, 17184, 185, 130, 190, 157, 62, 199, 137, 15)]
  internal interface IMobileBroadbandModemConfiguration
  {
    MobileBroadbandUicc Uicc { get; }

    string HomeProviderId { get; }

    string HomeProviderName { get; }
  }
}
