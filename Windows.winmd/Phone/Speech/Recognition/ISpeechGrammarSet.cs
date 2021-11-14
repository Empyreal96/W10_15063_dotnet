// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISpeechGrammarSet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(682968804, 40965, 16620, 184, 4, 75, 202, 98, 230, 219, 8)]
  [ExclusiveTo(typeof (SpeechGrammarSet))]
  internal interface ISpeechGrammarSet : 
    IMapView<string, SpeechGrammar>,
    IIterable<IKeyValuePair<string, SpeechGrammar>>
  {
    SpeechGrammar AddGrammarFromList(string key, IIterable<string> phrases);

    SpeechGrammar AddGrammarFromUri(string key, Uri grammarUri);

    SpeechGrammar AddGrammarFromPredefinedType(
      string key,
      SpeechPredefinedGrammar predefinedGrammarType);

    void Clear();
  }
}
