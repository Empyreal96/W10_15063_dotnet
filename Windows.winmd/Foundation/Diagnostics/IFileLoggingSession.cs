// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IFileLoggingSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(617038358, 65234, 16460, 137, 95, 31, 150, 153, 203, 2, 247)]
  public interface IFileLoggingSession : IClosable
  {
    string Name { get; }

    [Overload("AddLoggingChannel")]
    void AddLoggingChannel(ILoggingChannel loggingChannel);

    [Overload("AddLoggingChannelWithLevel")]
    void AddLoggingChannel(ILoggingChannel loggingChannel, LoggingLevel maxLevel);

    void RemoveLoggingChannel(ILoggingChannel loggingChannel);

    [RemoteAsync]
    IAsyncOperation<StorageFile> CloseAndSaveToFileAsync();

    event TypedEventHandler<IFileLoggingSession, LogFileGeneratedEventArgs> LogFileGenerated;
  }
}
