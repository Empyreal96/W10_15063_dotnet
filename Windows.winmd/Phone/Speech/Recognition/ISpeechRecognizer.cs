// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [Guid(637193011, 51849, 16558, 151, 185, 9, 129, 228, 178, 171, 171)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface ISpeechRecognizer : IClosable
  {
    IAsyncOperation<SpeechRecognitionResult> RecognizeAsync();

    IAsyncAction PreloadGrammarsAsync();

    SpeechRecognizerSettings Settings { get; }

    SpeechGrammarSet Grammars { get; }

    SpeechRecognizerInformation GetRecognizer();

    void SetRecognizer(SpeechRecognizerInformation recognizerInformation);

    event TypedEventHandler<SpeechRecognizer, SpeechAudioProblemOccurredEventArgs> AudioProblemOccurred;

    event TypedEventHandler<SpeechRecognizer, SpeechRecognizerAudioCaptureStateChangedEventArgs> AudioCaptureStateChanged;
  }
}
