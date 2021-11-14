// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionHypothesisGeneratedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionHypothesisGeneratedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1427511930, 32803, 22630, 65, 29, 18, 19, 187, 39, 20, 118)]
  internal interface ISpeechRecognitionHypothesisGeneratedEventArgs
  {
    SpeechRecognitionHypothesis Hypothesis { get; }
  }
}
