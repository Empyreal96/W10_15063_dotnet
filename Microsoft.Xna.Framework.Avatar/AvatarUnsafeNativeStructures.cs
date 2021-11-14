// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarUnsafeNativeStructures
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class AvatarUnsafeNativeStructures
  {
    internal struct AVATAR_EXPRESSION
    {
      public AvatarMouth Mouth;
      public AvatarEye LeftEye;
      public AvatarEye RightEye;
      public AvatarEyebrow LeftEyebrow;
      public AvatarEyebrow RightEyebrow;

      public AVATAR_EXPRESSION(ref AvatarExpression expression)
      {
        this.Mouth = expression.Mouth;
        this.LeftEye = expression.LeftEye;
        this.RightEye = expression.RightEye;
        this.LeftEyebrow = expression.LeftEyebrow;
        this.RightEyebrow = expression.RightEyebrow;
      }

      public void ToManagedExpression(ref AvatarExpression expression)
      {
        expression.Mouth = this.Mouth;
        expression.LeftEye = this.LeftEye;
        expression.RightEye = this.RightEye;
        expression.LeftEyebrow = this.LeftEyebrow;
        expression.RightEyebrow = this.RightEyebrow;
      }
    }

    internal struct AVATAR_DRAW_PARAMS
    {
      public Matrix World;
      public Matrix View;
      public Matrix Projection;
      public Vector3 LightColor;
      public Vector3 LightDirection;
      public Vector3 AmbientLightColor;
      public AvatarUnsafeNativeStructures.AVATAR_EXPRESSION Expression;

      public AVATAR_DRAW_PARAMS(AvatarRenderer renderer, ref AvatarExpression expression)
      {
        this.World = renderer.World;
        this.View = renderer.View;
        this.Projection = renderer.Projection;
        this.LightColor = renderer.LightColor;
        this.LightDirection = renderer.LightDirection;
        this.AmbientLightColor = renderer.AmbientLightColor;
        this.Expression = new AvatarUnsafeNativeStructures.AVATAR_EXPRESSION(ref expression);
      }

      public AVATAR_DRAW_PARAMS(AvatarRenderer renderer)
      {
        this.World = renderer.World;
        this.View = renderer.View;
        this.Projection = renderer.Projection;
        this.LightColor = renderer.LightColor;
        this.LightDirection = renderer.LightDirection;
        this.AmbientLightColor = renderer.AmbientLightColor;
        this.Expression = new AvatarUnsafeNativeStructures.AVATAR_EXPRESSION();
      }
    }

    internal struct AVATAR_BOUNDINGBOX
    {
      public float MinX;
      public float MinY;
      public float MinZ;
      public float MaxX;
      public float MaxY;
      public float MaxZ;
    }
  }
}
