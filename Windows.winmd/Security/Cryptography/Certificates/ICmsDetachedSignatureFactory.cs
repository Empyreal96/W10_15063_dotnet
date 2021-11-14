// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsDetachedSignatureFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3299554563, 44671, 17287, 173, 25, 0, 241, 80, 228, 142, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CmsDetachedSignature))]
  internal interface ICmsDetachedSignatureFactory
  {
    CmsDetachedSignature CreateCmsDetachedSignature(IBuffer inputBlob);
  }
}
