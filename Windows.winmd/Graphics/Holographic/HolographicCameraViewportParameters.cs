﻿// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCameraViewportParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Graphics.Holographic
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicCameraViewportParameters : IHolographicCameraViewportParameters
  {
    public extern Vector2[] HiddenAreaMesh { [MethodImpl] get; }

    public extern Vector2[] VisibleAreaMesh { [MethodImpl] get; }
  }
}
