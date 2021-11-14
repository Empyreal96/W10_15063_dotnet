// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  [Guid(197380555, 49770, 16626, 174, 181, 128, 150, 178, 228, 128, 115)]
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognizer : IClosable
  {
    Language CurrentLanguage { get; }

    IVector<ISpeechRecognitionConstraint> Constraints { get; }

    SpeechRecognizerTimeouts Timeouts { get; }

    SpeechRecognizerUIOptions UIOptions { get; }

    [RemoteAsync]
    IAsyncOperation<SpeechRecognitionCompilationResult> CompileConstraintsAsync();

    [RemoteAsync]
    IAsyncOperation<SpeechRecognitionResult> RecognizeAsync();

    [RemoteAsync]
    IAsyncOperation<SpeechRecognitionResult> RecognizeWithUIAsync();

    event TypedEventHandler<SpeechRecognizer, SpeechRecognitionQualityDegradingEventArgs> RecognitionQualityDegrading;

    event TypedEventHandler<SpeechRecognizer, SpeechRecognizerStateChangedEventArgs> StateChanged;
  }
}
