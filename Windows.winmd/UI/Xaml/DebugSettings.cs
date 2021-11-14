// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DebugSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class DebugSettings : IDebugSettings, IDebugSettings2, IDebugSettings3
  {
    public extern bool EnableFrameRateCounter { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsBindingTracingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOverdrawHeatMapEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event BindingFailedEventHandler BindingFailed;

    public extern bool EnableRedrawRegions { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextPerformanceVisualizationEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
