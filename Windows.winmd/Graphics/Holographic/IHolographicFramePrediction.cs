// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFramePrediction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (HolographicFramePrediction))]
  [Guid(1376734689, 23562, 20089, 168, 30, 106, 190, 2, 187, 39, 57)]
  internal interface IHolographicFramePrediction
  {
    IVectorView<HolographicCameraPose> CameraPoses { get; }

    PerceptionTimestamp Timestamp { get; }
  }
}
