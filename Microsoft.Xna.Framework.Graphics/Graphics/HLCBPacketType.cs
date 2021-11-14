// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.HLCBPacketType
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  internal enum HLCBPacketType
  {
    InvalidPacketType = 0,
    Clear = 1,
    SetIndexBuffer = 2,
    SetVertexDeclaration = 5,
    SetStreamSource = 6,
    SetTexture = 7,
    EffectSetValueBool = 8,
    EffectSetValueFloat = 9,
    EffectSetValueInt = 10, // 0x0000000A
    EffectSetValueMatrix = 11, // 0x0000000B
    EffectSetValueString = 12, // 0x0000000C
    EffectSetValueTexture = 13, // 0x0000000D
    EffectSetValueVector = 14, // 0x0000000E
    EffectSetValueMatrixTranspose = 15, // 0x0000000F
    EffectSetValueBoolArray = 16, // 0x00000010
    EffectSetValueFloatArray = 17, // 0x00000011
    EffectSetValueIntArray = 18, // 0x00000012
    EffectSetValueMatrixArray = 19, // 0x00000013
    EffectSetValueVectorArray = 20, // 0x00000014
    EffectSetValueMatrixTransposeArray = 21, // 0x00000015
    EffectApply = 22, // 0x00000016
    EffectSetTexture = 24, // 0x00000018
    SetBlendState = 25, // 0x00000019
    SetDepthStencilState = 26, // 0x0000001A
    SetRasterizerState = 27, // 0x0000001B
    SetSamplerState = 28, // 0x0000001C
    SetHighFrequencyState = 29, // 0x0000001D
    SetRenderTargets = 47, // 0x0000002F
    SetScissorRect = 48, // 0x00000030
    SetViewPort = 55, // 0x00000037
    DrawPrimitives = 56, // 0x00000038
    DrawIndexedPrimitives = 57, // 0x00000039
    DrawUserIndexedPrimitives = 58, // 0x0000003A
    DrawSprites = 59, // 0x0000003B
    EffectSetTechnique = 62, // 0x0000003E
    DrawUserPrimitives = 65, // 0x00000041
    BeginQuery = 66, // 0x00000042
    EndQuery = 67, // 0x00000043
    DrawInstancedPrimitives = 68, // 0x00000044
  }
}
