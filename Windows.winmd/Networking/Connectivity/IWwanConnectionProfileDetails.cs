// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IWwanConnectionProfileDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (WwanConnectionProfileDetails))]
  [ContractVersion(typeof (WwanContract), 65536)]
  [Guid(239970558, 33631, 19955, 130, 253, 223, 85, 110, 188, 9, 239)]
  internal interface IWwanConnectionProfileDetails
  {
    string HomeProviderId { get; }

    string AccessPointName { get; }

    WwanNetworkRegistrationState GetNetworkRegistrationState();

    WwanDataClass GetCurrentDataClass();
  }
}
