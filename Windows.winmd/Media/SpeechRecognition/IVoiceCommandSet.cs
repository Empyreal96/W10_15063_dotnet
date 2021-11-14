// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.IVoiceCommandSet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(200137333, 18150, 19217, 160, 136, 92, 104, 99, 40, 153, 181)]
  [ExclusiveTo(typeof (VoiceCommandSet))]
  internal interface IVoiceCommandSet
  {
    string Language { get; }

    string Name { get; }

    [RemoteAsync]
    IAsyncAction SetPhraseListAsync(string phraseListName, IIterable<string> phraseList);
  }
}
