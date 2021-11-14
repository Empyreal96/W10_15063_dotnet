// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMpeg2ProfileIdsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(2757885829, 58746, 16680, 155, 33, 213, 51, 27, 4, 35, 92)]
  [ExclusiveTo(typeof (Mpeg2ProfileIds))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMpeg2ProfileIdsStatics
  {
    int Simple { get; }

    int Main { get; }

    int SignalNoiseRatioScalable { get; }

    int SpatiallyScalable { get; }

    int High { get; }
  }
}
