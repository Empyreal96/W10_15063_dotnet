// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarAnimation
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.GamerServices
{
  public class AvatarAnimation : IAvatarAnimation, IDisposable
  {
    internal TimeSpan length;
    internal TimeSpan currentPosition;
    internal Matrix[] avatarBones = new Matrix[71];
    internal ReadOnlyCollection<Matrix> boneTransforms;
    internal object disposeLock = new object();
    private AvatarExpression currentExpression;
    private bool isDisposed;
    internal uint handle = uint.MaxValue;
    internal bool isPropAnimation;

    internal AvatarAnimation()
    {
    }

    public TimeSpan Length => this.length;

    public TimeSpan CurrentPosition
    {
      get => this.currentPosition;
      set
      {
        this.currentPosition = value;
        this.Update(TimeSpan.Zero, false);
      }
    }

    public ReadOnlyCollection<Matrix> BoneTransforms => this.boneTransforms;

    public AvatarExpression Expression => this.currentExpression;

    public bool IsDisposed => this.isDisposed;

    public AvatarAnimation(AvatarAnimationPreset animationPreset)
    {
      float animationLength = 0.0f;
      ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarAnimation_Create((uint) animationPreset, out this.handle, out animationLength));
      this.boneTransforms = new ReadOnlyCollection<Matrix>((IList<Matrix>) this.avatarBones);
      this.length = TimeSpan.FromTicks((long) ((double) animationLength * 10000000.0));
      this.currentPosition = TimeSpan.Zero;
      this.Update(TimeSpan.Zero, false);
    }

    public void Update(TimeSpan elapsedAnimationTime, bool loop)
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      try
      {
        this.currentPosition += elapsedAnimationTime;
      }
      catch (OverflowException ex)
      {
        this.currentPosition = !(elapsedAnimationTime > TimeSpan.Zero) ? TimeSpan.Zero : this.Length;
      }
      if (this.currentPosition > this.length)
        this.currentPosition = !loop || !(this.length != TimeSpan.Zero) ? this.length : TimeSpan.FromTicks(this.currentPosition.Ticks % this.length.Ticks);
      else if (this.currentPosition < TimeSpan.Zero)
        this.currentPosition = !loop || !(this.length != TimeSpan.Zero) ? TimeSpan.Zero : this.length + TimeSpan.FromTicks(this.currentPosition.Ticks % this.length.Ticks);
      lock (this.disposeLock)
      {
        if (this.handle == uint.MaxValue)
          return;
        AvatarUnsafeNativeStructures.AVATAR_EXPRESSION expression;
        int num = (int) SafeAvatarNativeMethods.AvatarAnimation_Update(this.handle, (float) this.currentPosition.TotalSeconds, this.avatarBones, out expression);
        expression.ToManagedExpression(ref this.currentExpression);
        ErrorHandler.ThrowExceptionFromResult((uint) num);
      }
    }

    ~AvatarAnimation() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      lock (this.disposeLock)
      {
        if (this.isDisposed)
          return;
        this.isDisposed = true;
        if (this.handle == uint.MaxValue)
          return;
        int num = (int) SafeAvatarNativeMethods.AvatarAnimation_ReleaseHandle(this.handle);
        this.handle = uint.MaxValue;
      }
    }
  }
}
