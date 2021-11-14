// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControlsTimelineProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (SystemMediaTransportControlsTimelineProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1361391978, 50082, 18267, 133, 7, 147, 83, 77, 200, 143, 21)]
  internal interface ISystemMediaTransportControlsTimelineProperties
  {
    TimeSpan StartTime { get; set; }

    TimeSpan EndTime { get; set; }

    TimeSpan MinSeekTime { get; set; }

    TimeSpan MaxSeekTime { get; set; }

    TimeSpan Position { get; set; }
  }
}
