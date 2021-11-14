// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredential
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class KeyCredential : IKeyCredential
  {
    public extern string Name { [MethodImpl] get; }

    [Overload("RetrievePublicKeyWithDefaultBlobType")]
    [MethodImpl]
    public extern IBuffer RetrievePublicKey();

    [Overload("RetrievePublicKeyWithBlobType")]
    [MethodImpl]
    public extern IBuffer RetrievePublicKey(CryptographicPublicKeyBlobType blobType);

    [MethodImpl]
    public extern IAsyncOperation<KeyCredentialOperationResult> RequestSignAsync(
      IBuffer data);

    [MethodImpl]
    public extern IAsyncOperation<KeyCredentialAttestationResult> GetAttestationAsync();
  }
}
