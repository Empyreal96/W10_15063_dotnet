// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentSubscriptionOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Guid(1643014864, 11395, 16923, 132, 103, 65, 62, 175, 26, 235, 151)]
  [ExclusiveTo(typeof (TargetedContentSubscriptionOptions))]
  internal interface ITargetedContentSubscriptionOptions
  {
    string SubscriptionId { get; }

    bool AllowPartialContentAvailability { get; set; }

    IMap<string, string> CloudQueryParameters { get; }

    IVector<string> LocalFilters { get; }

    void Update();
  }
}
