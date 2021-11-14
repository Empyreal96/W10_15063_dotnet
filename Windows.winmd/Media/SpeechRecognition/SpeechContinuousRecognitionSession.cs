// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechContinuousRecognitionSession : ISpeechContinuousRecognitionSession
  {
    public extern TimeSpan AutoStopSilenceTimeout { [MethodImpl] get; [MethodImpl] set; }

    [Overload("StartAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    [RemoteAsync]
    [Overload("StartWithModeAsync")]
    [MethodImpl]
    public extern IAsyncAction StartAsync(SpeechContinuousRecognitionMode mode);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CancelAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PauseAsync();

    [MethodImpl]
    public extern void Resume();

    public extern event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionCompletedEventArgs> Completed;

    public extern event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionResultGeneratedEventArgs> ResultGenerated;
  }
}
