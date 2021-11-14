// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFramePrediction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicFramePrediction : IHolographicFramePrediction
  {
    public extern IVectorView<HolographicCameraPose> CameraPoses { [MethodImpl] get; }

    public extern PerceptionTimestamp Timestamp { [MethodImpl] get; }
  }
}
