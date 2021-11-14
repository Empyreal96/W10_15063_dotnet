// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ICredentialCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (CredentialCommand))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2784388582, 24899, 19066, 169, 113, 176, 23, 186, 151, 140, 226)]
  internal interface ICredentialCommand
  {
    PasswordCredential PasswordCredential { get; }

    CredentialCommandCredentialDeletedHandler CredentialDeleted { get; }
  }
}
