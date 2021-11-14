// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.VoiceCommandSet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Media.SpeechRecognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class VoiceCommandSet : IVoiceCommandSet
  {
    public extern string Language { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPhraseListAsync(
      string phraseListName,
      IIterable<string> phraseList);
  }
}
