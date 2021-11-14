// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.CredentialCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  [Activatable(typeof (ICredentialCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CredentialCommand : ICredentialCommand
  {
    [MethodImpl]
    public extern CredentialCommand(PasswordCredential passwordCredential);

    [MethodImpl]
    public extern CredentialCommand(
      PasswordCredential passwordCredential,
      CredentialCommandCredentialDeletedHandler deleted);

    public extern PasswordCredential PasswordCredential { [MethodImpl] get; }

    public extern CredentialCommandCredentialDeletedHandler CredentialDeleted { [MethodImpl] get; }
  }
}
