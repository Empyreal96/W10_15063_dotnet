// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.VoiceCommands.IVoiceCommandSet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.VoiceCommands
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (VoiceCommandSet))]
  [Guid(3955440315, 61659, 20095, 164, 217, 71, 129, 165, 82, 214, 43)]
  internal interface IVoiceCommandSet
  {
    string Language { get; }

    string Name { get; }

    IAsyncAction UpdatePhraseListAsync(
      string phraseListName,
      IIterable<string> phraseList);
  }
}
