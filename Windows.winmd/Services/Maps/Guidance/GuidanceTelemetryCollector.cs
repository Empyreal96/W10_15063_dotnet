// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceTelemetryCollector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Static(typeof (IGuidanceTelemetryCollectorStatics), 65536, "Windows.Services.Maps.GuidanceContract")]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class GuidanceTelemetryCollector : IGuidanceTelemetryCollector
  {
    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void ClearLocalData();

    public extern double SpeedTrigger { [MethodImpl] get; [MethodImpl] set; }

    public extern int UploadFrequency { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern GuidanceTelemetryCollector GetCurrent();
  }
}
