// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ILoggingSessionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class LoggingSession : ILoggingSession, IClosable
  {
    [MethodImpl]
    public extern LoggingSession(string name);

    public extern string Name { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> SaveToFileAsync(
      IStorageFolder folder,
      string fileName);

    [Overload("AddLoggingChannel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel);

    [Overload("AddLoggingChannelWithLevel")]
    [MethodImpl]
    public extern void AddLoggingChannel(ILoggingChannel loggingChannel, LoggingLevel maxLevel);

    [MethodImpl]
    public extern void RemoveLoggingChannel(ILoggingChannel loggingChannel);

    [MethodImpl]
    public extern void Close();
  }
}
