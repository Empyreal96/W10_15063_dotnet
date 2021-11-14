// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.YCbCrPixelLayout
// Assembly: Microsoft.Devices.Camera, Version=0.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: EF9A4555-242B-4723-B191-4FF24D598391
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI27EF~1.DLL

namespace Microsoft.Devices
{
  public sealed class YCbCrPixelLayout
  {
    public int RequiredBufferSize { get; internal set; }

    public int YPitch { get; internal set; }

    public int YXPitch { get; internal set; }

    public int YOffset { get; internal set; }

    public int CbPitch { get; internal set; }

    public int CbXPitch { get; internal set; }

    public int CbOffset { get; internal set; }

    public int CrPitch { get; internal set; }

    public int CrXPitch { get; internal set; }

    public int CrOffset { get; internal set; }
  }
}
