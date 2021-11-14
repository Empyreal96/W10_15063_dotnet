// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1311781207, 846, 18002, 133, 126, 208, 69, 76, 196, 190, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognitionResult))]
  internal interface ISpeechRecognitionResult
  {
    SpeechRecognitionResultStatus Status { get; }

    string Text { get; }

    SpeechRecognitionConfidence Confidence { get; }

    SpeechRecognitionSemanticInterpretation SemanticInterpretation { get; }

    IVectorView<SpeechRecognitionResult> GetAlternates(
      uint maxAlternates);

    ISpeechRecognitionConstraint Constraint { get; }

    IVectorView<string> RulePath { get; }

    double RawConfidence { get; }
  }
}
