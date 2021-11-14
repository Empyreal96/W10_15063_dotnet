// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechRecognitionResult : ISpeechRecognitionResult, ISpeechRecognitionResult2
  {
    public extern SpeechRecognitionResultStatus Status { [MethodImpl] get; }

    public extern string Text { [MethodImpl] get; }

    public extern SpeechRecognitionConfidence Confidence { [MethodImpl] get; }

    public extern SpeechRecognitionSemanticInterpretation SemanticInterpretation { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SpeechRecognitionResult> GetAlternates(
      uint maxAlternates);

    public extern ISpeechRecognitionConstraint Constraint { [MethodImpl] get; }

    public extern IVectorView<string> RulePath { [MethodImpl] get; }

    public extern double RawConfidence { [MethodImpl] get; }

    public extern DateTime PhraseStartTime { [MethodImpl] get; }

    public extern TimeSpan PhraseDuration { [MethodImpl] get; }
  }
}
