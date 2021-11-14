// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerUIOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2022233665, 47403, 17594, 162, 95, 209, 134, 70, 48, 100, 31)]
  [ExclusiveTo(typeof (SpeechRecognizerUIOptions))]
  internal interface ISpeechRecognizerUIOptions
  {
    string ExampleText { get; set; }

    string AudiblePrompt { get; set; }

    bool IsReadBackEnabled { get; set; }

    bool ShowConfirmation { get; set; }
  }
}
