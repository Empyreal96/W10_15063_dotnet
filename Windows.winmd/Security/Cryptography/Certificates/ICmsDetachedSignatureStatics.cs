// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsDetachedSignatureStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1024543997, 49051, 18050, 155, 230, 145, 245, 124, 5, 56, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CmsDetachedSignature))]
  internal interface ICmsDetachedSignatureStatics
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IInputStream data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
