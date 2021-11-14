// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVoiceCommandDefinitionManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class VoiceCommandDefinitionManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction InstallCommandDefinitionsFromStorageFileAsync(
      StorageFile file);

    public static extern IMapView<string, VoiceCommandDefinition> InstalledCommandDefinitions { [MethodImpl] get; }
  }
}
