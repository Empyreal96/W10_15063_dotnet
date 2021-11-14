// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsAttachedSignature
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
  [Static(typeof (ICmsAttachedSignatureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ICmsAttachedSignatureFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class CmsAttachedSignature : ICmsAttachedSignature
  {
    [MethodImpl]
    public extern CmsAttachedSignature(IBuffer inputBlob);

    public extern IVectorView<Certificate> Certificates { [MethodImpl] get; }

    public extern byte[] Content { [MethodImpl] get; }

    public extern IVectorView<CmsSignerInfo> Signers { [MethodImpl] get; }

    [MethodImpl]
    public extern SignatureValidationResult VerifySignature();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IBuffer data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
