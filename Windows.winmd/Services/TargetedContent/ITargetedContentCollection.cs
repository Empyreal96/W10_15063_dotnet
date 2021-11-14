// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [Guid(759916229, 61795, 17594, 159, 110, 225, 164, 194, 187, 85, 157)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [ExclusiveTo(typeof (TargetedContentCollection))]
  internal interface ITargetedContentCollection
  {
    string Id { get; }

    void ReportInteraction(TargetedContentInteraction interaction);

    void ReportCustomInteraction(string customInteractionName);

    string Path { get; }

    IMapView<string, TargetedContentValue> Properties { get; }

    IVectorView<TargetedContentCollection> Collections { get; }

    IVectorView<TargetedContentItem> Items { get; }
  }
}
