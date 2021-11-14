// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentSubscriptionOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  public sealed class TargetedContentSubscriptionOptions : ITargetedContentSubscriptionOptions
  {
    public extern string SubscriptionId { [MethodImpl] get; }

    public extern bool AllowPartialContentAvailability { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, string> CloudQueryParameters { [MethodImpl] get; }

    public extern IVector<string> LocalFilters { [MethodImpl] get; }

    [MethodImpl]
    public extern void Update();
  }
}
