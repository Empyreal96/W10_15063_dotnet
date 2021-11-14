// Decompiled with JetBrains decompiler
// Type: Windows.Media.Render.AudioRenderCategory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Render
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioRenderCategory
  {
    Other,
    [Deprecated("ForegroundOnlyMedia is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] ForegroundOnlyMedia,
    [Deprecated("BackgroundCapableMedia is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] BackgroundCapableMedia,
    Communications,
    Alerts,
    SoundEffects,
    GameEffects,
    GameMedia,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] GameChat,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Speech,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Movie,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Media,
  }
}
