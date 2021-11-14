// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AsyncPropAnimationGrabber
// Assembly: Microsoft.Xna.Framework.AvatarExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4B8FF3A4-9C9B-4DC4-8C5B-7EE362249DCB
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB22~1.DLL

using GamerServices.Platforms.Web;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class AsyncPropAnimationGrabber : LIVEnTask
  {
    public uint animationHandle;
    public float animationLength;
    private AvatarDescription description;

    public AsyncPropAnimationGrabber(AvatarDescription description)
    {
      description.AddRef();
      this.description = description;
    }

    public override void Do()
    {
      try
      {
        ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarAnimation_CreatePropAnimation(this.description.kernelHandle, out this.animationHandle, out this.animationLength));
      }
      finally
      {
        this.description.ReleaseHandle();
      }
    }
  }
}
