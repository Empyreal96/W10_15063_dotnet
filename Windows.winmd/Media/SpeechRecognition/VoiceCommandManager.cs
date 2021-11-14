// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.VoiceCommandManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Phone;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVoiceCommandManager), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public static class VoiceCommandManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction InstallCommandSetsFromStorageFileAsync(
      StorageFile file);

    public static extern IMapView<string, VoiceCommandSet> InstalledCommandSets { [MethodImpl] get; }
  }
}
