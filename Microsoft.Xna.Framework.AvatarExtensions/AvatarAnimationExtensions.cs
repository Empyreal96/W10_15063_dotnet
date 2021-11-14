// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarAnimationExtensions
// Assembly: Microsoft.Xna.Framework.AvatarExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4B8FF3A4-9C9B-4DC4-8C5B-7EE362249DCB
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB22~1.DLL

namespace Microsoft.Xna.Framework.GamerServices
{
  public static class AvatarAnimationExtensions
  {
    public static BoundingBox GetBoundingBox(this AvatarAnimation animation)
    {
      AvatarUnsafeNativeStructures.AVATAR_BOUNDINGBOX bounds;
      ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarAnimation_GetBoundingBox(animation.handle, out bounds));
      return new BoundingBox(new Vector3(bounds.MinX, bounds.MinY, bounds.MinZ), new Vector3(bounds.MaxX, bounds.MaxY, bounds.MaxZ));
    }
  }
}
