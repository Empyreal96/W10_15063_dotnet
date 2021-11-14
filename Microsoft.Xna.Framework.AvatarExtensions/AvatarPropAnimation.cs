// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarPropAnimation
// Assembly: Microsoft.Xna.Framework.AvatarExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4B8FF3A4-9C9B-4DC4-8C5B-7EE362249DCB
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB22~1.DLL

using GamerServices.Platforms.Web;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.GamerServices
{
  public class AvatarPropAnimation : AvatarAnimation
  {
    public static AvatarPropAnimation GetAvatarPropAnimation(
      AvatarDescription description)
    {
      return AvatarPropAnimation.EndGetAvatarPropAnimation(AvatarPropAnimation.BeginGetAvatarPropAnimation(description, (AsyncCallback) null, (object) null));
    }

    public static IAsyncResult BeginGetAvatarPropAnimation(
      AvatarDescription description,
      AsyncCallback callback,
      object state)
    {
      return GamerServicesDispatcher.Gsp.QueueAsyncTask((LIVEnTask) new AsyncPropAnimationGrabber(description), callback, state);
    }

    public static AvatarPropAnimation EndGetAvatarPropAnimation(
      IAsyncResult result)
    {
      if (result == null)
        throw new ArgumentNullException(nameof (result));
      if (!(result is AsyncPropAnimationGrabber animationGrabber))
        throw new ArgumentException(FrameworkResources.IAsyncNotFromBegin);
      animationGrabber.EndProcessWithCheck();
      return new AvatarPropAnimation(animationGrabber.animationHandle, animationGrabber.animationLength);
    }

    private AvatarPropAnimation(uint animationHandle, float animationLength)
    {
      this.handle = animationHandle;
      this.isPropAnimation = true;
      this.boneTransforms = new ReadOnlyCollection<Matrix>((IList<Matrix>) this.avatarBones);
      this.length = TimeSpan.FromTicks((long) ((double) animationLength * 10000000.0));
      this.currentPosition = TimeSpan.Zero;
      this.Update(TimeSpan.Zero, false);
    }
  }
}
