// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  public sealed class TargetedContentCollection : ITargetedContentCollection
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportInteraction(TargetedContentInteraction interaction);

    [MethodImpl]
    public extern void ReportCustomInteraction(string customInteractionName);

    public extern string Path { [MethodImpl] get; }

    public extern IMapView<string, TargetedContentValue> Properties { [MethodImpl] get; }

    public extern IVectorView<TargetedContentCollection> Collections { [MethodImpl] get; }

    public extern IVectorView<TargetedContentItem> Items { [MethodImpl] get; }
  }
}
