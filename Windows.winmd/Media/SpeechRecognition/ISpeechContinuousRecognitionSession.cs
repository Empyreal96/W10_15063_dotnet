// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1780562948, 26132, 18936, 153, 162, 181, 233, 179, 160, 133, 200)]
  [ExclusiveTo(typeof (SpeechContinuousRecognitionSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechContinuousRecognitionSession
  {
    TimeSpan AutoStopSilenceTimeout { get; set; }

    [RemoteAsync]
    [Overload("StartAsync")]
    IAsyncAction StartAsync();

    [RemoteAsync]
    [Overload("StartWithModeAsync")]
    IAsyncAction StartAsync(SpeechContinuousRecognitionMode mode);

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncAction CancelAsync();

    [RemoteAsync]
    IAsyncAction PauseAsync();

    void Resume();

    event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionCompletedEventArgs> Completed;

    event TypedEventHandler<SpeechContinuousRecognitionSession, SpeechContinuousRecognitionResultGeneratedEventArgs> ResultGenerated;
  }
}
