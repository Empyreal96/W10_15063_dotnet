// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Guid(941002180, 10092, 19506, 150, 186, 86, 92, 110, 64, 110, 116)]
  [ExclusiveTo(typeof (TargetedContentItem))]
  internal interface ITargetedContentItem
  {
    string Path { get; }

    void ReportInteraction(TargetedContentInteraction interaction);

    void ReportCustomInteraction(string customInteractionName);

    TargetedContentItemState State { get; }

    IMapView<string, TargetedContentValue> Properties { get; }

    IVectorView<TargetedContentCollection> Collections { get; }
  }
}
