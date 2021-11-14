// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ICryptographicKey
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (CryptographicKey))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3978967920, 36475, 16393, 132, 1, 255, 209, 166, 46, 235, 39)]
  internal interface ICryptographicKey
  {
    uint KeySize { get; }

    [Overload("ExportDefaultPrivateKeyBlobType")]
    IBuffer Export();

    [Overload("ExportPrivateKeyWithBlobType")]
    IBuffer Export(CryptographicPrivateKeyBlobType BlobType);

    [Overload("ExportDefaultPublicKeyBlobType")]
    IBuffer ExportPublicKey();

    [Overload("ExportPublicKeyWithBlobType")]
    IBuffer ExportPublicKey(CryptographicPublicKeyBlobType BlobType);
  }
}
