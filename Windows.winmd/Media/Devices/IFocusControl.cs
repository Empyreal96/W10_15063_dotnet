// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFocusControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3235416566, 21032, 17491, 177, 83, 133, 96, 101, 146, 178, 56)]
  [ExclusiveTo(typeof (FocusControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFocusControl
  {
    bool Supported { get; }

    IVectorView<FocusPreset> SupportedPresets { get; }

    FocusPreset Preset { get; }

    [Overload("SetPresetAsync")]
    [RemoteAsync]
    IAsyncAction SetPresetAsync(FocusPreset preset);

    [Overload("SetPresetWithCompletionOptionAsync")]
    [RemoteAsync]
    IAsyncAction SetPresetAsync(FocusPreset preset, bool completeBeforeFocus);

    uint Min { get; }

    uint Max { get; }

    uint Step { get; }

    uint Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(uint focus);

    [RemoteAsync]
    IAsyncAction FocusAsync();
  }
}
