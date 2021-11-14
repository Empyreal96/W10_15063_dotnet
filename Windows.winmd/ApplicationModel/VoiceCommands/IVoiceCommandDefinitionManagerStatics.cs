// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandDefinitionManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommandDefinitionManager))]
  [Guid(2414323358, 1662, 20246, 161, 140, 91, 23, 233, 73, 153, 64)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandDefinitionManagerStatics
  {
    [RemoteAsync]
    IAsyncAction InstallCommandDefinitionsFromStorageFileAsync(StorageFile file);

    IMapView<string, VoiceCommandDefinition> InstalledCommandDefinitions { get; }
  }
}
