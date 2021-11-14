// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommandDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2037557968, 2420, 18809, 152, 75, 203, 137, 89, 205, 97, 174)]
  internal interface IVoiceCommandDefinition
  {
    string Language { get; }

    string Name { get; }

    [RemoteAsync]
    IAsyncAction SetPhraseListAsync(string phraseListName, IIterable<string> phraseList);
  }
}
