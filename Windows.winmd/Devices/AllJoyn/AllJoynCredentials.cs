// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynCredentials
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class AllJoynCredentials : IAllJoynCredentials
  {
    public extern AllJoynAuthenticationMechanism AuthenticationMechanism { [MethodImpl] get; }

    public extern Certificate Certificate { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential PasswordCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Timeout { [MethodImpl] get; [MethodImpl] set; }
  }
}
