// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.Texture3D
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class Texture3D : Texture
  {
    private int _width;
    private int _height;
    private int _depth;

    public Texture3D(
      GraphicsDevice graphicsDevice,
      int width,
      int height,
      int depth,
      bool mipMap,
      SurfaceFormat format)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      if (width <= 0)
        throw new ArgumentOutOfRangeException(nameof (width), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      if (height <= 0)
        throw new ArgumentOutOfRangeException(nameof (height), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      if (depth <= 0)
        throw new ArgumentOutOfRangeException(nameof (depth), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      ProfileCapabilities profileCapabilities = graphicsDevice._profileCapabilities;
      if (profileCapabilities.MaxVolumeExtent == 0)
        profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileFeatureNotSupported, (object) typeof (Texture3D).Name);
      if (!profileCapabilities.ValidVolumeFormats.Contains(format))
        profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileFormatNotSupported, (object) typeof (Texture3D).Name, (object) format);
      if (width > profileCapabilities.MaxVolumeExtent || height > profileCapabilities.MaxVolumeExtent || depth > profileCapabilities.MaxVolumeExtent)
        profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileTooBig, (object) typeof (Texture3D).Name, (object) profileCapabilities.MaxVolumeExtent);
      int num1 = Math.Max(Math.Max(width, height), depth);
      int num2 = Math.Min(Math.Min(width, height), depth);
      int num3 = num2;
      if ((num1 + num3 - 1) / num2 > profileCapabilities.MaxTextureAspectRatio)
        profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileAspectRatio, (object) typeof (Texture3D).Name, (object) profileCapabilities.MaxTextureAspectRatio);
      if (!profileCapabilities.NonPow2Volume && (!Texture.IsPowerOfTwo(width) || !Texture.IsPowerOfTwo(height) || !Texture.IsPowerOfTwo(depth)))
        profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNotPowerOfTwo, (object) typeof (Texture3D).Name);
      uint levelCount;
      this.pComPtr = UnsafeNativeMethods.Texture3D.GetGlobal(graphicsDevice).CreateTexture(graphicsDevice.pComPtr, new UnsafeNativeStructures.TEXTURE_CREATION_PARAMS((uint) width, (uint) height, (uint) depth, mipMap, format, 0), out levelCount);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this.InitializeDescription(graphicsDevice, format, levelCount);
      this._width = width;
      this._height = height;
      this._depth = depth;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    internal Texture3D(
      GraphicsDevice graphicsDevice,
      uint handle,
      UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters)
    {
      this.pComPtr = handle;
      this.InitializeDescription(graphicsDevice, parameters.dwFormat, parameters.dwLevels);
      this._width = (int) parameters.dwWidth;
      this._height = (int) parameters.dwHeight;
      this._depth = (int) parameters.dwDepth;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    [SecuritySafeCritical]
    public unsafe void GetData<T>(
      int level,
      int left,
      int top,
      int right,
      int bottom,
      int front,
      int back,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      Texture3D.ValidateParameters<T>(data, startIndex, elementCount);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        uint elementSize = Helpers.GetSizeOf<T>();
        UnsafeNativeStructures.TEXTURE3D_COPYDATA_INFO data1 = new UnsafeNativeStructures.TEXTURE3D_COPYDATA_INFO((void*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) elementSize)), level, elementSize, (uint) elementCount, left, top, right, bottom, front, back);
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Texture3D.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, ref data1, (byte) 1));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void GetData<T>(T[] data) where T : struct => this.GetData<T>(0, 0, 0, this._width, this._height, 0, this._depth, data, 0, data != null ? data.Length : 0);

    public void GetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.GetData<T>(0, 0, 0, this._width, this._height, 0, this._depth, data, startIndex, elementCount);

    [SecuritySafeCritical]
    public unsafe void SetData<T>(
      int level,
      int left,
      int top,
      int right,
      int bottom,
      int front,
      int back,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      Texture3D.ValidateParameters<T>(data, startIndex, elementCount);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        uint elementSize = Helpers.GetSizeOf<T>();
        UnsafeNativeStructures.TEXTURE3D_COPYDATA_INFO data1 = new UnsafeNativeStructures.TEXTURE3D_COPYDATA_INFO((void*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) elementSize)), level, elementSize, (uint) elementCount, left, top, right, bottom, front, back);
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Texture3D.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, ref data1, (byte) 0));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void SetData<T>(T[] data) where T : struct => this.SetData<T>(0, 0, 0, this._width, this._height, 0, this._depth, data, 0, data != null ? data.Length : 0);

    public void SetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.SetData<T>(0, 0, 0, this._width, this._height, 0, this._depth, data, startIndex, elementCount);

    private static void ValidateParameters<T>(T[] data, int startIndex, int elementCount) where T : struct
    {
      if (data == null || data.Length == 0)
        throw new ArgumentNullException(nameof (data), FrameworkResources.ResourceDataMustBeCorrectSize);
      Helpers.ValidateCopyParameters(data.Length, startIndex, elementCount);
    }

    public int Width => this._width;

    public int Height => this._height;

    public int Depth => this._depth;

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.pComPtr == uint.MaxValue)
          return;
        UnsafeNativeMethods.Texture3D.GetGlobal(this._parent).ReleaseHandle(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr);
        if (this._parent == null)
          return;
        this._parent.FireDestroyedEvent(this._name, this._tag, this.pComPtr);
      }
      finally
      {
        base.Dispose(disposing);
      }
    }
  }
}
