// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.RenderTargetBinding
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public struct RenderTargetBinding
  {
    internal Texture _renderTarget;
    internal CubeMapFace _cubeMapFace;

    public RenderTargetBinding(RenderTarget2D renderTarget)
    {
      this._renderTarget = renderTarget != null ? (Texture) renderTarget : throw new ArgumentNullException(nameof (renderTarget), FrameworkResources.NullNotAllowed);
      this._cubeMapFace = CubeMapFace.PositiveX;
    }

    public RenderTargetBinding(RenderTargetCube renderTarget, CubeMapFace cubeMapFace)
    {
      this._renderTarget = renderTarget != null ? (Texture) renderTarget : throw new ArgumentNullException(nameof (renderTarget), FrameworkResources.NullNotAllowed);
      this._cubeMapFace = cubeMapFace;
    }

    public static implicit operator RenderTargetBinding(
      RenderTarget2D renderTarget)
    {
      return new RenderTargetBinding(renderTarget);
    }

    public Texture RenderTarget => this._renderTarget;

    public CubeMapFace CubeMapFace => this._cubeMapFace;
  }
}
