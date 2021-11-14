// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionQualityDegradingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionQualityDegradingEventArgs))]
  [Guid(1340227845, 35898, 19582, 141, 10, 91, 212, 245, 177, 74, 216)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognitionQualityDegradingEventArgs
  {
    SpeechRecognitionAudioProblem Problem { get; }
  }
}
