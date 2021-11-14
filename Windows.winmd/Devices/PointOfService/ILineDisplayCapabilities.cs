// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplayCapabilities))]
  [Guid(1511372241, 36293, 19356, 145, 114, 48, 62, 71, 183, 12, 85)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ILineDisplayCapabilities
  {
    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool CanChangeScreenSize { get; }

    bool CanDisplayBitmaps { get; }

    bool CanReadCharacterAtCursor { get; }

    bool CanMapCharacterSets { get; }

    bool CanDisplayCustomGlyphs { get; }

    LineDisplayTextAttributeGranularity CanReverse { get; }

    LineDisplayTextAttributeGranularity CanBlink { get; }

    bool CanChangeBlinkRate { get; }

    bool IsBrightnessSupported { get; }

    bool IsCursorSupported { get; }

    bool IsHorizontalMarqueeSupported { get; }

    bool IsVerticalMarqueeSupported { get; }

    bool IsInterCharacterWaitSupported { get; }

    uint SupportedDescriptors { get; }

    uint SupportedWindows { get; }
  }
}
