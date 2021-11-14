// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPickedCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnPickedCredential))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2591636167, 34900, 20050, 173, 151, 36, 221, 154, 132, 43, 206)]
  internal interface IVpnPickedCredential
  {
    PasswordCredential PasskeyCredential { get; }

    string AdditionalPin { get; }

    PasswordCredential OldPasswordCredential { get; }
  }
}
