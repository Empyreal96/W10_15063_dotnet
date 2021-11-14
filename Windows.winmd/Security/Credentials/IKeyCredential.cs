// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyCredential))]
  [Guid(2508582797, 17787, 18503, 177, 26, 250, 150, 11, 189, 177, 56)]
  internal interface IKeyCredential
  {
    string Name { get; }

    [Overload("RetrievePublicKeyWithDefaultBlobType")]
    IBuffer RetrievePublicKey();

    [Overload("RetrievePublicKeyWithBlobType")]
    IBuffer RetrievePublicKey(CryptographicPublicKeyBlobType blobType);

    IAsyncOperation<KeyCredentialOperationResult> RequestSignAsync(
      IBuffer data);

    IAsyncOperation<KeyCredentialAttestationResult> GetAttestationAsync();
  }
}
