// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentItem
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
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TargetedContentItem : ITargetedContentItem
  {
    public extern string Path { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportInteraction(TargetedContentInteraction interaction);

    [MethodImpl]
    public extern void ReportCustomInteraction(string customInteractionName);

    public extern TargetedContentItemState State { [MethodImpl] get; }

    public extern IMapView<string, TargetedContentValue> Properties { [MethodImpl] get; }

    public extern IVectorView<TargetedContentCollection> Collections { [MethodImpl] get; }
  }
}
