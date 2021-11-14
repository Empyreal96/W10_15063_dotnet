// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeyAttestationHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IKeyAttestationHelperStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IKeyAttestationHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KeyAttestationHelper
  {
    [Overload("DecryptTpmAttestationCredentialWithContainerNameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(
      string credential,
      string containerName);

    [RemoteAsync]
    [Overload("DecryptTpmAttestationCredentialAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(
      string credential);

    [MethodImpl]
    public static extern string GetTpmAttestationCredentialId(string credential);
  }
}
