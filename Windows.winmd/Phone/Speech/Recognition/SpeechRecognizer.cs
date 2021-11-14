// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.SpeechRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechRecognizer : ISpeechRecognizer, IClosable
  {
    [MethodImpl]
    public extern SpeechRecognizer();

    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionResult> RecognizeAsync();

    [MethodImpl]
    public extern IAsyncAction PreloadGrammarsAsync();

    public extern SpeechRecognizerSettings Settings { [MethodImpl] get; }

    public extern SpeechGrammarSet Grammars { [MethodImpl] get; }

    [MethodImpl]
    public extern SpeechRecognizerInformation GetRecognizer();

    [MethodImpl]
    public extern void SetRecognizer(SpeechRecognizerInformation recognizerInformation);

    public extern event TypedEventHandler<SpeechRecognizer, SpeechAudioProblemOccurredEventArgs> AudioProblemOccurred;

    public extern event TypedEventHandler<SpeechRecognizer, SpeechRecognizerAudioCaptureStateChangedEventArgs> AudioCaptureStateChanged;

    [MethodImpl]
    public extern void Close();
  }
}
