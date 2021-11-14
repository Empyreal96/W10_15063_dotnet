// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ICredentialCommandFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CredentialCommand))]
  [Guid(669551639, 48190, 19328, 148, 149, 78, 215, 32, 228, 138, 145)]
  internal interface ICredentialCommandFactory
  {
    CredentialCommand CreateCredentialCommand(PasswordCredential passwordCredential);

    CredentialCommand CreateCredentialCommandWithHandler(
      PasswordCredential passwordCredential,
      CredentialCommandCredentialDeletedHandler deleted);
  }
}
