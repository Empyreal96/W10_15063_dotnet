// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechAudioProblemOccurredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechAudioProblemOccurredEventArgs))]
  [Guid(2381067986, 50083, 16703, 148, 183, 222, 12, 198, 241, 202, 154)]
  internal interface ISpeechAudioProblemOccurredEventArgs
  {
    SpeechRecognitionAudioProblem Problem { get; }
  }
}
