// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.VoiceCommands.VoiceCommandService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.VoiceCommands
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVoiceCommandService), 65536, "Windows.Phone.PhoneInternalContract")]
  public static class VoiceCommandService
  {
    [MethodImpl]
    public static extern IAsyncAction InstallCommandSetsFromFileAsync(
      Uri voiceCommandDefinitionUri);

    public static extern IMapView<string, VoiceCommandSet> InstalledCommandSets { [MethodImpl] get; }
  }
}
