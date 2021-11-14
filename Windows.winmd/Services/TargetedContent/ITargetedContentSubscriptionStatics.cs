// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentSubscriptionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Guid(4208852608, 13837, 18710, 181, 60, 126, 162, 112, 144, 208, 42)]
  [ExclusiveTo(typeof (TargetedContentSubscription))]
  internal interface ITargetedContentSubscriptionStatics
  {
    [RemoteAsync]
    IAsyncOperation<TargetedContentSubscription> GetAsync(
      string subscriptionId);

    TargetedContentSubscriptionOptions GetOptions(
      string subscriptionId);
  }
}
