// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsDetachedSignature
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICmsDetachedSignatureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (ICmsDetachedSignatureFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CmsDetachedSignature : ICmsDetachedSignature
  {
    [MethodImpl]
    public extern CmsDetachedSignature(IBuffer inputBlob);

    public extern IVectorView<Certificate> Certificates { [MethodImpl] get; }

    public extern IVectorView<CmsSignerInfo> Signers { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SignatureValidationResult> VerifySignatureAsync(
      IInputStream data);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IInputStream data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
