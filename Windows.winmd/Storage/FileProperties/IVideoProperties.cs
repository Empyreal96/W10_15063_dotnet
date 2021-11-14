// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IVideoProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [Guid(1905976583, 26846, 19896, 151, 222, 73, 153, 140, 5, 159, 47)]
  [ExclusiveTo(typeof (VideoProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoProperties : IStorageItemExtraProperties
  {
    uint Rating { get; set; }

    IVector<string> Keywords { get; }

    uint Width { get; }

    uint Height { get; }

    TimeSpan Duration { get; }

    IReference<double> Latitude { get; }

    IReference<double> Longitude { get; }

    string Title { get; set; }

    string Subtitle { get; set; }

    IVector<string> Producers { get; }

    string Publisher { get; set; }

    IVector<string> Writers { get; }

    uint Year { get; set; }

    uint Bitrate { get; }

    IVector<string> Directors { get; }

    VideoOrientation Orientation { get; }
  }
}
