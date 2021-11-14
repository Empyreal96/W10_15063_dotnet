// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.DataProtectionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.EnterpriseData
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Static(typeof (IDataProtectionManagerStatics), 65536, "Windows.Security.EnterpriseData.EnterpriseDataContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public static class DataProtectionManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BufferProtectUnprotectResult> ProtectAsync(
      IBuffer data,
      string identity);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BufferProtectUnprotectResult> UnprotectAsync(
      IBuffer data);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DataProtectionInfo> ProtectStreamAsync(
      IInputStream unprotectedStream,
      string identity,
      IOutputStream protectedStream);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DataProtectionInfo> UnprotectStreamAsync(
      IInputStream protectedStream,
      IOutputStream unprotectedStream);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DataProtectionInfo> GetProtectionInfoAsync(
      IBuffer protectedData);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DataProtectionInfo> GetStreamProtectionInfoAsync(
      IInputStream protectedStream);
  }
}
