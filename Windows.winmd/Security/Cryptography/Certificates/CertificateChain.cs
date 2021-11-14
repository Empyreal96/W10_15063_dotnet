// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateChain
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  public sealed class CertificateChain : ICertificateChain
  {
    [Overload("Validate")]
    [MethodImpl]
    public extern ChainValidationResult Validate();

    [Overload("ValidateWithParameters")]
    [MethodImpl]
    public extern ChainValidationResult Validate(
      ChainValidationParameters parameter);

    [MethodImpl]
    public extern IVectorView<Certificate> GetCertificates(bool includeRoot);
  }
}
