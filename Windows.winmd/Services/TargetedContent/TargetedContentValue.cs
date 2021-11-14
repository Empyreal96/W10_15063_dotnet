// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TargetedContentValue : ITargetedContentValue
  {
    public extern TargetedContentValueKind ValueKind { [MethodImpl] get; }

    public extern string Path { [MethodImpl] get; }

    public extern string String { [MethodImpl] get; }

    public extern Uri Uri { [MethodImpl] get; }

    public extern double Number { [MethodImpl] get; }

    public extern bool Boolean { [MethodImpl] get; }

    public extern TargetedContentFile File { [MethodImpl] get; }

    public extern TargetedContentImage ImageFile { [MethodImpl] get; }

    public extern TargetedContentAction Action { [MethodImpl] get; }

    public extern IVectorView<string> Strings { [MethodImpl] get; }

    public extern IVectorView<Uri> Uris { [MethodImpl] get; }

    public extern IVectorView<double> Numbers { [MethodImpl] get; }

    public extern IVectorView<bool> Booleans { [MethodImpl] get; }

    public extern IVectorView<TargetedContentFile> Files { [MethodImpl] get; }

    public extern IVectorView<TargetedContentImage> ImageFiles { [MethodImpl] get; }

    public extern IVectorView<TargetedContentAction> Actions { [MethodImpl] get; }
  }
}
