// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.Direct3DBindings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Direct3DBindings : uint
  {
    VertexBuffer = 1,
    IndexBuffer = 2,
    ConstantBuffer = 4,
    ShaderResource = 8,
    StreamOutput = 16, // 0x00000010
    RenderTarget = 32, // 0x00000020
    DepthStencil = 64, // 0x00000040
    UnorderedAccess = 128, // 0x00000080
    Decoder = 512, // 0x00000200
    VideoEncoder = 1024, // 0x00000400
  }
}
