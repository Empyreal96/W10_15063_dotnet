// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorInfo2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Guid(349798819, 64550, 20471, 171, 195, 72, 232, 42, 81, 42, 10)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorInfo))]
  internal interface ISecondaryAuthenticationFactorInfo2 : ISecondaryAuthenticationFactorInfo
  {
    SecondaryAuthenticationFactorDevicePresenceMonitoringMode PresenceMonitoringMode { get; }

    [RemoteAsync]
    IAsyncAction UpdateDevicePresenceAsync(
      SecondaryAuthenticationFactorDevicePresence presenceState);

    bool IsAuthenticationSupported { get; }
  }
}
