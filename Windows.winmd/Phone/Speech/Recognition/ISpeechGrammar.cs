// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechGrammar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SpeechGrammar))]
  [Guid(450126986, 37921, 19083, 159, 72, 211, 99, 122, 224, 233, 12)]
  internal interface ISpeechGrammar
  {
    bool Enabled { get; set; }

    SpeechGrammarProbability Probability { get; set; }
  }
}
