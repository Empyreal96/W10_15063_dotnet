// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognizerSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizerSettings))]
  [Guid(2263257498, 53614, 19535, 175, 9, 255, 53, 179, 200, 112, 12)]
  internal interface ISpeechRecognizerSettings
  {
    TimeSpan InitialSilenceTimeout { get; set; }

    TimeSpan EndSilenceTimeout { get; set; }

    TimeSpan BabbleTimeout { get; set; }
  }
}
