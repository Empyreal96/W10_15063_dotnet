// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyAttestationHelperStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (KeyAttestationHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2623081260, 42694, 19038, 158, 100, 232, 93, 82, 121, 223, 151)]
  internal interface IKeyAttestationHelperStatics2
  {
    [Overload("DecryptTpmAttestationCredentialWithContainerNameAsync")]
    [RemoteAsync]
    IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(
      string credential,
      string containerName);
  }
}
