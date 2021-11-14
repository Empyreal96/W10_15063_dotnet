// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISpeechRecognizerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISpeechRecognizerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpeechRecognizer : ISpeechRecognizer, IClosable, ISpeechRecognizer2
  {
    [MethodImpl]
    public extern SpeechRecognizer(Language language);

    [MethodImpl]
    public extern SpeechRecognizer();

    public extern Language CurrentLanguage { [MethodImpl] get; }

    public extern IVector<ISpeechRecognitionConstraint> Constraints { [MethodImpl] get; }

    public extern SpeechRecognizerTimeouts Timeouts { [MethodImpl] get; }

    public extern SpeechRecognizerUIOptions UIOptions { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionCompilationResult> CompileConstraintsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionResult> RecognizeAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionResult> RecognizeWithUIAsync();

    public extern event TypedEventHandler<SpeechRecognizer, SpeechRecognitionQualityDegradingEventArgs> RecognitionQualityDegrading;

    public extern event TypedEventHandler<SpeechRecognizer, SpeechRecognizerStateChangedEventArgs> StateChanged;

    [MethodImpl]
    public extern void Close();

    public extern SpeechContinuousRecognitionSession ContinuousRecognitionSession { [MethodImpl] get; }

    public extern SpeechRecognizerState State { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopRecognitionAsync();

    public extern event TypedEventHandler<SpeechRecognizer, SpeechRecognitionHypothesisGeneratedEventArgs> HypothesisGenerated;

    public static extern Language SystemSpeechLanguage { [MethodImpl] get; }

    public static extern IVectorView<Language> SupportedTopicLanguages { [MethodImpl] get; }

    public static extern IVectorView<Language> SupportedGrammarLanguages { [MethodImpl] get; }
  }
}
