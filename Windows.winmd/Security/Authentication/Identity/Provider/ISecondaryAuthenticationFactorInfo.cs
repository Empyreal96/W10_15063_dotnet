// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(506177633, 34099, 20430, 131, 155, 236, 183, 36, 16, 172, 20)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorInfo))]
  internal interface ISecondaryAuthenticationFactorInfo
  {
    string DeviceId { get; }

    string DeviceFriendlyName { get; }

    string DeviceModelNumber { get; }

    IBuffer DeviceConfigurationData { get; }
  }
}
