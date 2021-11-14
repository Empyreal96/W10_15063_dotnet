// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionResultStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SpeechRecognitionResultStatus
  {
    Success,
    TopicLanguageNotSupported,
    GrammarLanguageMismatch,
    GrammarCompilationFailure,
    AudioQualityFailure,
    UserCanceled,
    Unknown,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TimeoutExceeded,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PauseLimitExceeded,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NetworkFailure,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] MicrophoneUnavailable,
  }
}
