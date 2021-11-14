// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkSecuritySettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2090892941, 37243, 19295, 184, 77, 40, 247, 165, 172, 84, 2)]
  [ExclusiveTo(typeof (NetworkSecuritySettings))]
  internal interface INetworkSecuritySettings
  {
    NetworkAuthenticationType NetworkAuthenticationType { get; }

    NetworkEncryptionType NetworkEncryptionType { get; }
  }
}
