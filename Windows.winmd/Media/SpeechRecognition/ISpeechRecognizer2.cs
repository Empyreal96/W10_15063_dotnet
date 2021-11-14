// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [Guid(1674164977, 37347, 20132, 134, 161, 124, 56, 103, 208, 132, 166)]
  internal interface ISpeechRecognizer2
  {
    SpeechContinuousRecognitionSession ContinuousRecognitionSession { get; }

    SpeechRecognizerState State { get; }

    [RemoteAsync]
    IAsyncAction StopRecognitionAsync();

    event TypedEventHandler<SpeechRecognizer, SpeechRecognitionHypothesisGeneratedEventArgs> HypothesisGenerated;
  }
}
