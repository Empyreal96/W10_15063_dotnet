// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.IHdmiDisplayInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [ExclusiveTo(typeof (HdmiDisplayInformation))]
  [Guid(319503370, 62821, 18286, 171, 213, 234, 5, 174, 231, 76, 105)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHdmiDisplayInformation
  {
    IVectorView<HdmiDisplayMode> GetSupportedDisplayModes();

    HdmiDisplayMode GetCurrentDisplayMode();

    [RemoteAsync]
    IAsyncAction SetDefaultDisplayModeAsync();

    [Overload("RequestSetCurrentDisplayModeAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(HdmiDisplayMode mode);

    [Overload("RequestSetCurrentDisplayModeWithHdrAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption);

    [Overload("RequestSetCurrentDisplayModeWithHdrAndMetadataAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption,
      HdmiDisplayHdr2086Metadata hdrMetadata);

    event TypedEventHandler<HdmiDisplayInformation, object> DisplayModesChanged;
  }
}
