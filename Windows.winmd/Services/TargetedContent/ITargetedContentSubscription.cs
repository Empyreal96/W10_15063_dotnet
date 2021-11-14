// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentSubscription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [Guid(2284596297, 50770, 19578, 172, 173, 31, 127, 162, 152, 108, 115)]
  [ExclusiveTo(typeof (TargetedContentSubscription))]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  internal interface ITargetedContentSubscription
  {
    string Id { get; }

    [RemoteAsync]
    IAsyncOperation<TargetedContentContainer> GetContentContainerAsync();

    event TypedEventHandler<TargetedContentSubscription, TargetedContentChangedEventArgs> ContentChanged;

    event TypedEventHandler<TargetedContentSubscription, TargetedContentAvailabilityChangedEventArgs> AvailabilityChanged;

    event TypedEventHandler<TargetedContentSubscription, TargetedContentStateChangedEventArgs> StateChanged;
  }
}
