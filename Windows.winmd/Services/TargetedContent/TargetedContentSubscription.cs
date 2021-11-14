// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentSubscription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITargetedContentSubscriptionStatics), 65536, "Windows.Services.TargetedContent.TargetedContentContract")]
  [DualApiPartition(version = 167772163)]
  public sealed class TargetedContentSubscription : ITargetedContentSubscription
  {
    public extern string Id { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<TargetedContentContainer> GetContentContainerAsync();

    public extern event TypedEventHandler<TargetedContentSubscription, TargetedContentChangedEventArgs> ContentChanged;

    public extern event TypedEventHandler<TargetedContentSubscription, TargetedContentAvailabilityChangedEventArgs> AvailabilityChanged;

    public extern event TypedEventHandler<TargetedContentSubscription, TargetedContentStateChangedEventArgs> StateChanged;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<TargetedContentSubscription> GetAsync(
      string subscriptionId);

    [MethodImpl]
    public static extern TargetedContentSubscriptionOptions GetOptions(
      string subscriptionId);
  }
}
