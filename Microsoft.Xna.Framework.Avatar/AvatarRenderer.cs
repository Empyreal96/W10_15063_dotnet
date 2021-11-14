// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarRenderer
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using GamerServices.Platforms.Web;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.GamerServices
{
  public class AvatarRenderer : IDisposable
  {
    private Matrix world = Matrix.Identity;
    private Matrix view = Matrix.Identity;
    private Matrix projection = Matrix.Identity;
    private int[] parentBoneIDs = new int[71]
    {
      -1,
      0,
      0,
      0,
      0,
      1,
      2,
      2,
      3,
      3,
      1,
      6,
      5,
      6,
      5,
      8,
      5,
      8,
      5,
      14,
      12,
      11,
      16,
      15,
      14,
      20,
      20,
      20,
      22,
      22,
      22,
      25,
      25,
      25,
      28,
      28,
      28,
      33,
      33,
      33,
      33,
      33,
      33,
      33,
      36,
      36,
      36,
      36,
      36,
      36,
      36,
      37,
      38,
      39,
      40,
      43,
      44,
      45,
      46,
      47,
      50,
      51,
      52,
      53,
      54,
      55,
      56,
      57,
      58,
      59,
      60
    };
    private ReadOnlyCollection<int> parentBones;
    private ReadOnlyCollection<Matrix> bindPose;
    private Matrix[] bindPoseArray = new Matrix[71];
    internal object disposeLock = new object();
    private Matrix[] drawBones = new Matrix[71];
    private AvatarRendererState state = AvatarRendererState.Unavailable;
    private bool isDisposed;
    internal volatile uint handle = uint.MaxValue;
    [CLSCompliant(false)]
    public const int BoneCount = 71;

    public Matrix World
    {
      get => this.world;
      set => this.world = value;
    }

    public Matrix View
    {
      get => this.view;
      set => this.view = value;
    }

    public Matrix Projection
    {
      get => this.projection;
      set => this.projection = value;
    }

    public ReadOnlyCollection<int> ParentBones => this.parentBones;

    public ReadOnlyCollection<Matrix> BindPose => this.GetBindPose();

    private ReadOnlyCollection<Matrix> GetBindPose()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (this.state != AvatarRendererState.Ready)
        throw new InvalidOperationException(FrameworkResources.BindPoseNotAvailable);
      lock (this.bindPoseArray)
      {
        if (this.bindPose == null)
        {
          if (this.handle != uint.MaxValue)
            ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarRenderer_GetBindPose(this.handle, this.bindPoseArray));
          this.bindPose = new ReadOnlyCollection<Matrix>((IList<Matrix>) this.bindPoseArray);
        }
      }
      return this.bindPose;
    }

    public AvatarRendererState State
    {
      get
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.state == AvatarRendererState.Loading)
        {
          int num = 0;
          if (this.handle != uint.MaxValue)
            num = 1;
          if (num != 0)
            this.state = AvatarRendererState.Ready;
        }
        return this.state;
      }
    }

    public Vector3 LightColor { get; set; }

    public Vector3 LightDirection { get; set; }

    public Vector3 AmbientLightColor { get; set; }

    public bool IsDisposed => this.isDisposed;

    public AvatarRenderer(AvatarDescription avatarDescription)
      : this(avatarDescription, true)
    {
    }

    public AvatarRenderer(AvatarDescription avatarDescription, bool useLoadingEffect)
    {
      if (avatarDescription == null)
        throw new ArgumentNullException(nameof (avatarDescription));
      if (avatarDescription.IsValid)
      {
        GamerServicesDispatcher.Gsp.QueueAsyncTask((LIVEnTask) new AvatarRenderer.AsyncRendererGenerator(AvatarHelpers.GraphicsDevice.pComPtr, avatarDescription), new AsyncCallback(this.RendererCreateCompleted), (object) null);
        this.LightColor = new Vector3(0.4f, 0.4f, 0.4f);
        this.LightDirection = new Vector3(-0.5f, -0.6123f, -0.6123f);
        this.AmbientLightColor = new Vector3(0.55f, 0.55f, 0.55f);
        if (false)
          this.handle = uint.MaxValue;
        else
          this.state = AvatarRendererState.Loading;
      }
      this.parentBones = new ReadOnlyCollection<int>((IList<int>) this.parentBoneIDs);
    }

    public void Draw(IAvatarAnimation animation)
    {
      AvatarAnimation avatarAnimation = animation != null ? animation as AvatarAnimation : throw new ArgumentNullException(nameof (animation));
      if (avatarAnimation.isPropAnimation)
      {
        lock (this.disposeLock)
        {
          lock (avatarAnimation.disposeLock)
          {
            if (this.handle == uint.MaxValue || avatarAnimation.handle == uint.MaxValue)
              return;
            AvatarHelpers.GraphicsDevice.FlushBuffer();
            AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS drawParams = new AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS(this);
            ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarRenderer_DrawWithProp(AvatarHelpers.GraphicsDevice.pComPtr, this.handle, avatarAnimation.handle, ref drawParams));
          }
        }
      }
      else
        this.Draw((IList<Matrix>) animation.BoneTransforms, animation.Expression);
    }

    public void Draw(IList<Matrix> bones, AvatarExpression expression)
    {
      lock (this.disposeLock)
      {
        if (this.isDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (bones == null)
          throw new ArgumentNullException(nameof (bones));
        if (bones.Count != 71)
          throw new ArgumentException(FrameworkResources.ResourceDataMustBeCorrectSize, nameof (bones));
        if (this.handle == uint.MaxValue)
          return;
        AvatarHelpers.GraphicsDevice.FlushBuffer();
        AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS drawParams = new AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS(this, ref expression);
        for (int index = 0; index < 71; ++index)
          this.drawBones[index] = bones[index];
        ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarRenderer_Draw(AvatarHelpers.GraphicsDevice.pComPtr, this.handle, ref drawParams, this.drawBones));
      }
    }

    ~AvatarRenderer() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      lock (this)
      {
        if (this.isDisposed)
          return;
        this.isDisposed = true;
        if (this.handle != uint.MaxValue)
        {
          uint graphicsDeviceHandle = uint.MaxValue;
          try
          {
            graphicsDeviceHandle = AvatarHelpers.GraphicsDevice.pComPtr;
          }
          catch (InvalidOperationException ex)
          {
          }
          int num = (int) SafeAvatarNativeMethods.AvatarRenderer_ReleaseHandle(graphicsDeviceHandle, this.handle);
          this.handle = uint.MaxValue;
        }
        if (this.handle == uint.MaxValue)
          return;
        this.handle = uint.MaxValue;
      }
    }

    private void RendererCreateCompleted(IAsyncResult result)
    {
      lock (this)
      {
        AvatarRenderer.AsyncRendererGenerator rendererGenerator = result as AvatarRenderer.AsyncRendererGenerator;
        if (rendererGenerator.resultCode != 0U)
          return;
        this.handle = rendererGenerator.rendererHandle;
      }
    }

    private class AsyncRendererGenerator : LIVEnTask
    {
      public AvatarDescription description;
      public uint rendererHandle;
      public uint resultCode;
      private uint graphicsDeviceHandle;

      public AsyncRendererGenerator(uint graphicsDeviceHandle, AvatarDescription description)
      {
        description.AddRef();
        this.description = description;
        this.graphicsDeviceHandle = graphicsDeviceHandle;
      }

      public override void Do() => this.GetRenderer();

      private void GetRenderer()
      {
        try
        {
          this.resultCode = SafeAvatarNativeMethods.AvatarRenderer_Create(this.graphicsDeviceHandle, this.description.kernelHandle, out this.rendererHandle);
        }
        finally
        {
          this.description.ReleaseHandle();
        }
      }
    }
  }
}
