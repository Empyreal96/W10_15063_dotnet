// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionTopicConstraint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISpeechRecognitionTopicConstraintFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechRecognitionTopicConstraint : 
    ISpeechRecognitionTopicConstraint,
    ISpeechRecognitionConstraint
  {
    [MethodImpl]
    public extern SpeechRecognitionTopicConstraint(
      SpeechRecognitionScenario scenario,
      string topicHint);

    [MethodImpl]
    public extern SpeechRecognitionTopicConstraint(
      SpeechRecognitionScenario scenario,
      string topicHint,
      string tag);

    public extern SpeechRecognitionScenario Scenario { [MethodImpl] get; }

    public extern string TopicHint { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    public extern SpeechRecognitionConstraintType Type { [MethodImpl] get; }

    public extern SpeechRecognitionConstraintProbability Probability { [MethodImpl] get; [MethodImpl] set; }
  }
}
