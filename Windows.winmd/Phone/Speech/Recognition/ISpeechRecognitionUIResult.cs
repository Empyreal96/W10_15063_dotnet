// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognitionUIResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(2911099315, 58020, 17953, 132, 194, 128, 111, 73, 83, 50, 54)]
  [ExclusiveTo(typeof (SpeechRecognitionUIResult))]
  internal interface ISpeechRecognitionUIResult
  {
    SpeechRecognitionUIStatus ResultStatus { get; }

    SpeechRecognitionResult RecognitionResult { get; }
  }
}
