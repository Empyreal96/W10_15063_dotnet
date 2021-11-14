// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionTopicConstraintFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1852335071, 60421, 18391, 165, 223, 86, 163, 67, 30, 88, 210)]
  [ExclusiveTo(typeof (SpeechRecognitionTopicConstraint))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognitionTopicConstraintFactory
  {
    SpeechRecognitionTopicConstraint Create(
      SpeechRecognitionScenario scenario,
      string topicHint);

    SpeechRecognitionTopicConstraint CreateWithTag(
      SpeechRecognitionScenario scenario,
      string topicHint,
      string tag);
  }
}
