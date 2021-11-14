// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyAttestationHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyAttestationHelper))]
  [Guid(373875270, 63044, 17190, 136, 190, 58, 241, 2, 211, 14, 12)]
  internal interface IKeyAttestationHelperStatics
  {
    [Overload("DecryptTpmAttestationCredentialAsync")]
    [RemoteAsync]
    IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(string credential);

    string GetTpmAttestationCredentialId(string credential);
  }
}
