// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.ICredentialFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PasswordCredential))]
  [Guid(1424954273, 48934, 18357, 151, 221, 222, 119, 155, 124, 173, 88)]
  internal interface ICredentialFactory
  {
    PasswordCredential CreatePasswordCredential(
      string resource,
      string userName,
      string password);
  }
}
