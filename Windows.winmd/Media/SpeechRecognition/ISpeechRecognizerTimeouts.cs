// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerTimeouts
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizerTimeouts))]
  [Guid(787967946, 27196, 19914, 161, 83, 223, 27, 200, 138, 121, 175)]
  internal interface ISpeechRecognizerTimeouts
  {
    TimeSpan InitialSilenceTimeout { get; set; }

    TimeSpan EndSilenceTimeout { get; set; }

    TimeSpan BabbleTimeout { get; set; }
  }
}
