// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [Static(typeof (IHdmiDisplayInformationStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class HdmiDisplayInformation : IHdmiDisplayInformation
  {
    [MethodImpl]
    public extern IVectorView<HdmiDisplayMode> GetSupportedDisplayModes();

    [MethodImpl]
    public extern HdmiDisplayMode GetCurrentDisplayMode();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetDefaultDisplayModeAsync();

    [RemoteAsync]
    [Overload("RequestSetCurrentDisplayModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode);

    [RemoteAsync]
    [Overload("RequestSetCurrentDisplayModeWithHdrAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption);

    [RemoteAsync]
    [Overload("RequestSetCurrentDisplayModeWithHdrAndMetadataAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption,
      HdmiDisplayHdr2086Metadata hdrMetadata);

    public extern event TypedEventHandler<HdmiDisplayInformation, object> DisplayModesChanged;

    [MethodImpl]
    public static extern HdmiDisplayInformation GetForCurrentView();
  }
}
