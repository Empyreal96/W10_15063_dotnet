// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IKeyCredentialManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class KeyCredentialManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsSupportedAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction RenewAttestationAsync();

    [MethodImpl]
    public static extern IAsyncOperation<KeyCredentialRetrievalResult> RequestCreateAsync(
      string name,
      KeyCredentialCreationOption option);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<KeyCredentialRetrievalResult> OpenAsync(
      string name);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DeleteAsync(string name);
  }
}
