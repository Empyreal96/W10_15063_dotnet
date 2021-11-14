// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IMediaProcessingTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaProcessingTrigger))]
  [Guid(2593504869, 35410, 19248, 144, 17, 207, 56, 4, 14, 168, 176)]
  internal interface IMediaProcessingTrigger : IBackgroundTrigger
  {
    [Overload("RequestAsync")]
    [RemoteAsync]
    IAsyncOperation<MediaProcessingTriggerResult> RequestAsync();

    [Overload("RequestAsyncWithArguments")]
    IAsyncOperation<MediaProcessingTriggerResult> RequestAsync(
      ValueSet arguments);
  }
}
