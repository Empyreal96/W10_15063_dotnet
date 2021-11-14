// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynCredentials
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynCredentials))]
  [Guid(2185646322, 41360, 16561, 171, 171, 52, 158, 194, 68, 223, 170)]
  internal interface IAllJoynCredentials
  {
    AllJoynAuthenticationMechanism AuthenticationMechanism { get; }

    Certificate Certificate { get; set; }

    PasswordCredential PasswordCredential { get; set; }

    TimeSpan Timeout { get; set; }
  }
}
