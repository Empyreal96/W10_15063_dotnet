// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineDisplayCapabilities : ILineDisplayCapabilities
  {
    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    public extern bool CanChangeScreenSize { [MethodImpl] get; }

    public extern bool CanDisplayBitmaps { [MethodImpl] get; }

    public extern bool CanReadCharacterAtCursor { [MethodImpl] get; }

    public extern bool CanMapCharacterSets { [MethodImpl] get; }

    public extern bool CanDisplayCustomGlyphs { [MethodImpl] get; }

    public extern LineDisplayTextAttributeGranularity CanReverse { [MethodImpl] get; }

    public extern LineDisplayTextAttributeGranularity CanBlink { [MethodImpl] get; }

    public extern bool CanChangeBlinkRate { [MethodImpl] get; }

    public extern bool IsBrightnessSupported { [MethodImpl] get; }

    public extern bool IsCursorSupported { [MethodImpl] get; }

    public extern bool IsHorizontalMarqueeSupported { [MethodImpl] get; }

    public extern bool IsVerticalMarqueeSupported { [MethodImpl] get; }

    public extern bool IsInterCharacterWaitSupported { [MethodImpl] get; }

    public extern uint SupportedDescriptors { [MethodImpl] get; }

    public extern uint SupportedWindows { [MethodImpl] get; }
  }
}
