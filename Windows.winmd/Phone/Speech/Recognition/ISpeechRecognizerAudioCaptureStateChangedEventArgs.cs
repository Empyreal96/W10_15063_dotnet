// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognizerAudioCaptureStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(1844780452, 15080, 20254, 141, 81, 140, 173, 232, 53, 207, 138)]
  [ExclusiveTo(typeof (SpeechRecognizerAudioCaptureStateChangedEventArgs))]
  internal interface ISpeechRecognizerAudioCaptureStateChangedEventArgs
  {
    SpeechRecognizerAudioCaptureState State { get; }
  }
}
