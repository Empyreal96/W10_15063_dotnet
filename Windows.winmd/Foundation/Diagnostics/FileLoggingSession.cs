// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.FileLoggingSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IFileLoggingSessionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FileLoggingSession : IFileLoggingSession, IClosable
  {
    [MethodImpl]
    public extern FileLoggingSession(string name);

    public extern string Name { [MethodImpl] get; }

    [Overload("AddLoggingChannel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel);

    [Overload("AddLoggingChannelWithLevel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel, LoggingLevel maxLevel);

    [MethodImpl]
    public extern void RemoveLoggingChannel(ILoggingChannel loggingChannel);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CloseAndSaveToFileAsync();

    public extern event TypedEventHandler<IFileLoggingSession, LogFileGeneratedEventArgs> LogFileGenerated;

    [MethodImpl]
    public extern void Close();
  }
}
