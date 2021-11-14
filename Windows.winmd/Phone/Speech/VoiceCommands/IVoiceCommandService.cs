// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.VoiceCommands.IVoiceCommandService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.VoiceCommands
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(567141430, 18157, 17875, 134, 68, 93, 31, 100, 22, 49, 106)]
  [ExclusiveTo(typeof (VoiceCommandService))]
  internal interface IVoiceCommandService
  {
    IAsyncAction InstallCommandSetsFromFileAsync(Uri voiceCommandDefinitionUri);

    IMapView<string, VoiceCommandSet> InstalledCommandSets { get; }
  }
}
