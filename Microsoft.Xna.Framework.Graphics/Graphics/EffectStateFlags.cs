// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectStateFlags
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  [Flags]
  internal enum EffectStateFlags : uint
  {
    None = 0,
    Blend = 1,
    DepthStencil = 2,
    Rasterizer = 4,
    Sampler0 = 8,
    Sampler1 = 16, // 0x00000010
    Sampler2 = 32, // 0x00000020
    Sampler3 = 64, // 0x00000040
    Sampler4 = 128, // 0x00000080
    Sampler5 = 256, // 0x00000100
    Sampler6 = 512, // 0x00000200
    Sampler7 = 1024, // 0x00000400
    Sampler8 = 2048, // 0x00000800
    Sampler9 = 4096, // 0x00001000
    Sampler10 = 8192, // 0x00002000
    Sampler11 = 16384, // 0x00004000
    Sampler12 = 32768, // 0x00008000
    Sampler13 = 65536, // 0x00010000
    Sampler14 = 131072, // 0x00020000
    Sampler15 = 262144, // 0x00040000
    VertexSampler0 = 524288, // 0x00080000
    VertexSampler1 = 1048576, // 0x00100000
    VertexSampler2 = 2097152, // 0x00200000
    VertexSampler3 = 4194304, // 0x00400000
    AllSamplers = Sampler15 | Sampler14 | Sampler13 | Sampler12 | Sampler11 | Sampler10 | Sampler9 | Sampler8 | Sampler7 | Sampler6 | Sampler5 | Sampler4 | Sampler3 | Sampler2 | Sampler1 | Sampler0, // 0x0007FFF8
    AllVertexSamplers = VertexSampler3 | VertexSampler2 | VertexSampler1 | VertexSampler0, // 0x00780000
  }
}
