// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsAttachedSignatureFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3502832661, 63319, 19556, 163, 98, 82, 204, 28, 119, 207, 251)]
  [ExclusiveTo(typeof (CmsAttachedSignature))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICmsAttachedSignatureFactory
  {
    CmsAttachedSignature CreateCmsAttachedSignature(IBuffer inputBlob);
  }
}
