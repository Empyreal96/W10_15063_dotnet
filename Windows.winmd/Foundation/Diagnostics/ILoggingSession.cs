// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  [Guid(1646392070, 37760, 19159, 186, 245, 65, 234, 147, 16, 215, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ILoggingSession : IClosable
  {
    string Name { get; }

    [RemoteAsync]
    IAsyncOperation<StorageFile> SaveToFileAsync(
      IStorageFolder folder,
      string fileName);

    [Overload("AddLoggingChannel")]
    void AddLoggingChannel(ILoggingChannel loggingChannel);

    [Overload("AddLoggingChannelWithLevel")]
    void AddLoggingChannel(ILoggingChannel loggingChannel, LoggingLevel maxLevel);

    void RemoveLoggingChannel(ILoggingChannel loggingChannel);
  }
}
