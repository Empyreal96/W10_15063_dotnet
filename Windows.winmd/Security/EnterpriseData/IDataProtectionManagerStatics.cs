// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.IDataProtectionManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.EnterpriseData
{
  [Guid(3054803828, 37188, 20196, 138, 138, 48, 181, 243, 97, 67, 14)]
  [ExclusiveTo(typeof (DataProtectionManager))]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  internal interface IDataProtectionManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<BufferProtectUnprotectResult> ProtectAsync(
      IBuffer data,
      string identity);

    [RemoteAsync]
    IAsyncOperation<BufferProtectUnprotectResult> UnprotectAsync(
      IBuffer data);

    [RemoteAsync]
    IAsyncOperation<DataProtectionInfo> ProtectStreamAsync(
      IInputStream unprotectedStream,
      string identity,
      IOutputStream protectedStream);

    [RemoteAsync]
    IAsyncOperation<DataProtectionInfo> UnprotectStreamAsync(
      IInputStream protectedStream,
      IOutputStream unprotectedStream);

    [RemoteAsync]
    IAsyncOperation<DataProtectionInfo> GetProtectionInfoAsync(
      IBuffer protectedData);

    [RemoteAsync]
    IAsyncOperation<DataProtectionInfo> GetStreamProtectionInfoAsync(
      IInputStream protectedStream);
  }
}
