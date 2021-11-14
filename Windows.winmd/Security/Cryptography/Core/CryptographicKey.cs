// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicKey
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CryptographicKey : ICryptographicKey
  {
    public extern uint KeySize { [MethodImpl] get; }

    [Overload("ExportDefaultPrivateKeyBlobType")]
    [MethodImpl]
    public extern IBuffer Export();

    [Overload("ExportPrivateKeyWithBlobType")]
    [MethodImpl]
    public extern IBuffer Export(CryptographicPrivateKeyBlobType BlobType);

    [Overload("ExportDefaultPublicKeyBlobType")]
    [MethodImpl]
    public extern IBuffer ExportPublicKey();

    [Overload("ExportPublicKeyWithBlobType")]
    [MethodImpl]
    public extern IBuffer ExportPublicKey(CryptographicPublicKeyBlobType BlobType);
  }
}
