﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameFlashControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772160)]
  public sealed class FrameFlashControl : IFrameFlashControl
  {
    public extern FrameFlashMode Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Auto { [MethodImpl] get; [MethodImpl] set; }

    public extern bool RedEyeReduction { [MethodImpl] get; [MethodImpl] set; }

    public extern float PowerPercent { [MethodImpl] get; [MethodImpl] set; }
  }
}
