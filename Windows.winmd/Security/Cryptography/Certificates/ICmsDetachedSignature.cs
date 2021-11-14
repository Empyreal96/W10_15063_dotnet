// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsDetachedSignature
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CmsDetachedSignature))]
  [Guid(253686100, 63070, 17718, 131, 57, 89, 68, 8, 29, 178, 202)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICmsDetachedSignature
  {
    IVectorView<Certificate> Certificates { get; }

    IVectorView<CmsSignerInfo> Signers { get; }

    [RemoteAsync]
    IAsyncOperation<SignatureValidationResult> VerifySignatureAsync(
      IInputStream data);
  }
}
