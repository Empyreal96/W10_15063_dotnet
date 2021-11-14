// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceAdvancedSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class AdaptiveMediaSourceAdvancedSettings : IAdaptiveMediaSourceAdvancedSettings
  {
    public extern bool AllSegmentsIndependent { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<double> DesiredBitrateHeadroomRatio { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<double> BitrateDowngradeTriggerRatio { [MethodImpl] get; [MethodImpl] set; }
  }
}
