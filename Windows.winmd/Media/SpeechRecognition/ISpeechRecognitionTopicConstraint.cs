// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionTopicConstraint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3211779865, 33373, 20073, 166, 129, 54, 228, 140, 241, 201, 62)]
  [ExclusiveTo(typeof (SpeechRecognitionTopicConstraint))]
  internal interface ISpeechRecognitionTopicConstraint : ISpeechRecognitionConstraint
  {
    SpeechRecognitionScenario Scenario { get; }

    string TopicHint { get; }
  }
}
