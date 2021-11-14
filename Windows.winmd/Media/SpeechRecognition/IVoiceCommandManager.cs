// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.IVoiceCommandManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Phone;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(2855964117, 46823, 20194, 186, 169, 221, 107, 172, 237, 10, 43)]
  [ExclusiveTo(typeof (VoiceCommandManager))]
  internal interface IVoiceCommandManager
  {
    [RemoteAsync]
    IAsyncAction InstallCommandSetsFromStorageFileAsync(StorageFile file);

    IMapView<string, VoiceCommandSet> InstalledCommandSets { get; }
  }
}
