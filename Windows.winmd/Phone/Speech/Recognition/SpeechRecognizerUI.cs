// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.SpeechRecognizerUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [Activatable(65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechRecognizerUI : ISpeechRecognizerUI, IClosable
  {
    [MethodImpl]
    public extern SpeechRecognizerUI();

    [MethodImpl]
    public extern IAsyncOperation<SpeechRecognitionUIResult> RecognizeWithUIAsync();

    public extern SpeechRecognizerUISettings Settings { [MethodImpl] get; }

    public extern SpeechRecognizer Recognizer { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
