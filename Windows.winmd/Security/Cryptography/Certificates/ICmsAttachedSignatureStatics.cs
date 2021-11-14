// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsAttachedSignatureStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(2274925710, 45229, 18829, 167, 245, 120, 181, 155, 206, 75, 54)]
  [ExclusiveTo(typeof (CmsAttachedSignature))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICmsAttachedSignatureStatics
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IBuffer data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
