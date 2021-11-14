// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectDirtyFlags
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  [Flags]
  internal enum EffectDirtyFlags
  {
    WorldViewProj = 1,
    World = 2,
    EyePosition = 4,
    MaterialColor = 8,
    Fog = 16, // 0x00000010
    FogEnable = 32, // 0x00000020
    AlphaTest = 64, // 0x00000040
    ShaderIndex = 128, // 0x00000080
    All = -1, // 0xFFFFFFFF
  }
}
