// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechRecognitionResultDetail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [Guid(3736864595, 23045, 18163, 161, 166, 10, 83, 128, 13, 0, 124)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognitionResultDetail))]
  internal interface ISpeechRecognitionResultDetail
  {
    IVectorView<string> RuleStack { get; }

    float ConfidenceScore { get; }
  }
}
