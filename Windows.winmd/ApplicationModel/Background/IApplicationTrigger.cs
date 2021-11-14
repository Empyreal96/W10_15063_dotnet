// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IApplicationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(189171248, 38260, 18732, 158, 147, 26, 58, 230, 51, 95, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationTrigger))]
  internal interface IApplicationTrigger : IBackgroundTrigger
  {
    [Overload("RequestAsync")]
    [RemoteAsync]
    IAsyncOperation<ApplicationTriggerResult> RequestAsync();

    [Overload("RequestAsyncWithArguments")]
    IAsyncOperation<ApplicationTriggerResult> RequestAsync(
      ValueSet arguments);
  }
}
