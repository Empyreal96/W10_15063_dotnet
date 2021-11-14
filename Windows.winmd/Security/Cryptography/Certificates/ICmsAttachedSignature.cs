// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsAttachedSignature
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1636408733, 14167, 20171, 189, 220, 12, 163, 87, 215, 169, 54)]
  [ExclusiveTo(typeof (CmsAttachedSignature))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICmsAttachedSignature
  {
    IVectorView<Certificate> Certificates { get; }

    byte[] Content { get; }

    IVectorView<CmsSignerInfo> Signers { get; }

    SignatureValidationResult VerifySignature();
  }
}
