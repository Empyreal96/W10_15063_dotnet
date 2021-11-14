// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPickedCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnPickedCredential : IVpnPickedCredential
  {
    public extern PasswordCredential PasskeyCredential { [MethodImpl] get; }

    public extern string AdditionalPin { [MethodImpl] get; }

    public extern PasswordCredential OldPasswordCredential { [MethodImpl] get; }
  }
}
