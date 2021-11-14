// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControlsTimelineProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 167772160)]
  public sealed class SystemMediaTransportControlsTimelineProperties : 
    ISystemMediaTransportControlsTimelineProperties
  {
    [MethodImpl]
    public extern SystemMediaTransportControlsTimelineProperties();

    public extern TimeSpan StartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan EndTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan MinSeekTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan MaxSeekTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }
  }
}
