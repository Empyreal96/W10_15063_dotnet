// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IPasswordVault
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [Guid(1643981835, 51412, 18625, 165, 79, 188, 90, 100, 32, 90, 242)]
  [ExclusiveTo(typeof (PasswordVault))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPasswordVault
  {
    void Add(PasswordCredential credential);

    void Remove(PasswordCredential credential);

    PasswordCredential Retrieve(string resource, string userName);

    IVectorView<PasswordCredential> FindAllByResource(string resource);

    IVectorView<PasswordCredential> FindAllByUserName(string userName);

    IVectorView<PasswordCredential> RetrieveAll();
  }
}
