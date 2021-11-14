// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.DataProtection.DataProtectionProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.DataProtection
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IDataProtectionProviderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class DataProtectionProvider : IDataProtectionProvider
  {
    [MethodImpl]
    public extern DataProtectionProvider(string protectionDescriptor);

    [MethodImpl]
    public extern DataProtectionProvider();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> ProtectAsync(IBuffer data);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> UnprotectAsync(IBuffer data);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ProtectStreamAsync(IInputStream src, IOutputStream dest);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnprotectStreamAsync(
      IInputStream src,
      IOutputStream dest);
  }
}
