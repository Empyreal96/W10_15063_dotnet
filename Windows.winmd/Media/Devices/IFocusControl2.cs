// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFocusControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (FocusControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1065156424, 50484, 20126, 148, 195, 82, 239, 42, 253, 93, 7)]
  internal interface IFocusControl2
  {
    bool FocusChangedSupported { get; }

    bool WaitForFocusSupported { get; }

    IVectorView<FocusMode> SupportedFocusModes { get; }

    IVectorView<ManualFocusDistance> SupportedFocusDistances { get; }

    IVectorView<AutoFocusRange> SupportedFocusRanges { get; }

    FocusMode Mode { get; }

    MediaCaptureFocusState FocusState { get; }

    [RemoteAsync]
    IAsyncAction UnlockAsync();

    [RemoteAsync]
    IAsyncAction LockAsync();

    void Configure(FocusSettings settings);
  }
}
