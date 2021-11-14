// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioRenderEffectsManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (AudioRenderEffectsManager))]
  [Guid(2823081225, 24268, 17587, 187, 78, 29, 176, 114, 135, 19, 156)]
  [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioRenderEffectsManager2
  {
    IRandomAccessStreamWithContentType EffectsProviderThumbnail { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string EffectsProviderSettingsLabel { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ShowSettingsUI();
  }
}
