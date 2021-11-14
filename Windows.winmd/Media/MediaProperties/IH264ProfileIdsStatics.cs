// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IH264ProfileIdsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(946162855, 33898, 20375, 162, 229, 195, 161, 91, 191, 112, 253)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (H264ProfileIds))]
  internal interface IH264ProfileIdsStatics
  {
    int ConstrainedBaseline { get; }

    int Baseline { get; }

    int Extended { get; }

    int Main { get; }

    int High { get; }

    int High10 { get; }

    int High422 { get; }

    int High444 { get; }

    int StereoHigh { get; }

    int MultiviewHigh { get; }
  }
}
