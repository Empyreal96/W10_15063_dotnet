// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.SpeechGrammarSet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechGrammarSet : 
    ISpeechGrammarSet,
    IMapView<string, SpeechGrammar>,
    IIterable<IKeyValuePair<string, SpeechGrammar>>
  {
    [MethodImpl]
    public extern SpeechGrammar AddGrammarFromList(
      string key,
      IIterable<string> phrases);

    [MethodImpl]
    public extern SpeechGrammar AddGrammarFromUri(string key, Uri grammarUri);

    [MethodImpl]
    public extern SpeechGrammar AddGrammarFromPredefinedType(
      string key,
      SpeechPredefinedGrammar predefinedGrammarType);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern SpeechGrammar Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, SpeechGrammar> first,
      out IMapView<string, SpeechGrammar> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, SpeechGrammar>> First();
  }
}
