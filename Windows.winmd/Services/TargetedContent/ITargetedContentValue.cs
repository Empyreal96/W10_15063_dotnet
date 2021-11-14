// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Guid(2868765875, 16917, 19448, 134, 127, 67, 240, 72, 101, 249, 191)]
  [ExclusiveTo(typeof (TargetedContentValue))]
  internal interface ITargetedContentValue
  {
    TargetedContentValueKind ValueKind { get; }

    string Path { get; }

    string String { get; }

    Uri Uri { get; }

    double Number { get; }

    bool Boolean { get; }

    TargetedContentFile File { get; }

    TargetedContentImage ImageFile { get; }

    TargetedContentAction Action { get; }

    IVectorView<string> Strings { get; }

    IVectorView<Uri> Uris { get; }

    IVectorView<double> Numbers { get; }

    IVectorView<bool> Booleans { get; }

    IVectorView<TargetedContentFile> Files { get; }

    IVectorView<TargetedContentImage> ImageFiles { get; }

    IVectorView<TargetedContentAction> Actions { get; }
  }
}
