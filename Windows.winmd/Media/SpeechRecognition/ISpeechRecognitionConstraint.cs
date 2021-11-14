// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2041321000, 19816, 17348, 137, 17, 64, 220, 65, 1, 181, 91)]
  public interface ISpeechRecognitionConstraint
  {
    bool IsEnabled { get; set; }

    string Tag { get; set; }

    SpeechRecognitionConstraintType Type { get; }

    SpeechRecognitionConstraintProbability Probability { get; set; }
  }
}
