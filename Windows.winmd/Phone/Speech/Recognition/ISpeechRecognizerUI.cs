// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognizerUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [Guid(1311099935, 6919, 18095, 160, 249, 169, 163, 69, 162, 25, 127)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizerUI))]
  internal interface ISpeechRecognizerUI : IClosable
  {
    IAsyncOperation<SpeechRecognitionUIResult> RecognizeWithUIAsync();

    SpeechRecognizerUISettings Settings { get; }

    SpeechRecognizer Recognizer { get; }
  }
}
