// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.TextureCube
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class TextureCube : Texture
  {
    internal int _size;

    internal TextureCube()
    {
    }

    public TextureCube(GraphicsDevice graphicsDevice, int size, bool mipMap, SurfaceFormat format)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      TextureCube.ValidateCreationParameters(graphicsDevice._profileCapabilities, size, format);
      uint levelCount;
      this.pComPtr = UnsafeNativeMethods.TextureCube.GetGlobal(graphicsDevice).CreateTexture(graphicsDevice.pComPtr, new UnsafeNativeStructures.TEXTURE_CREATION_PARAMS((uint) size, 0U, 0U, mipMap, format, 0), out levelCount);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this.InitializeDescription(graphicsDevice, format, levelCount);
      this._size = size;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    internal TextureCube(
      GraphicsDevice graphicsDevice,
      uint handle,
      UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters)
    {
      this.pComPtr = handle;
      this.InitializeDescription(graphicsDevice, parameters.dwFormat, parameters.dwLevels);
      this._size = (int) parameters.dwWidth;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    internal static void ValidateCreationParameters(
      ProfileCapabilities profile,
      int size,
      SurfaceFormat format)
    {
      if (size <= 0)
        throw new ArgumentOutOfRangeException(nameof (size), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      if (!profile.ValidCubeFormats.Contains(format))
        profile.ThrowNotSupportedException(FrameworkResources.ProfileFormatNotSupported, (object) typeof (TextureCube).Name, (object) format);
      if (size > profile.MaxCubeSize)
        profile.ThrowNotSupportedException(FrameworkResources.ProfileTooBig, (object) typeof (TextureCube).Name, (object) profile.MaxCubeSize);
      if (!profile.NonPow2Cube && !Texture.IsPowerOfTwo(size))
        profile.ThrowNotSupportedException(FrameworkResources.ProfileNotPowerOfTwo, (object) typeof (TextureCube).Name);
      if (Texture.IsCompressed(format) && (size & 3) != 0)
        throw new ArgumentException(FrameworkResources.DxtNotMultipleOfFour);
    }

    [SecuritySafeCritical]
    public unsafe void GetData<T>(
      CubeMapFace cubeMapFace,
      int level,
      Rectangle? rect,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      TextureCube.ValidateParameters<T>(data, startIndex, elementCount);
      if (this.isActiveRenderTarget)
        throw new InvalidOperationException(FrameworkResources.MustResolveRenderTarget);
      Rectangle* pRect = !rect.HasValue ? (Rectangle*) null : &rect.Value;
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        uint elementSize = Helpers.GetSizeOf<T>();
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) elementSize));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.TextureCube.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, new UnsafeNativeStructures.TEXTURECUBE_COPYDATA_INFO((uint) level, cubeMapFace, elementSize, (uint) elementCount), pRect, (byte) 1));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void GetData<T>(CubeMapFace cubeMapFace, T[] data) where T : struct => this.GetData<T>(cubeMapFace, 0, new Rectangle?(), data, 0, data != null ? data.Length : 0);

    public void GetData<T>(CubeMapFace cubeMapFace, T[] data, int startIndex, int elementCount) where T : struct => this.GetData<T>(cubeMapFace, 0, new Rectangle?(), data, startIndex, elementCount);

    [SecuritySafeCritical]
    public unsafe void SetData<T>(
      CubeMapFace cubeMapFace,
      int level,
      Rectangle? rect,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      TextureCube.ValidateParameters<T>(data, startIndex, elementCount);
      if (this.isActiveRenderTarget)
        throw new InvalidOperationException(FrameworkResources.MustResolveRenderTarget);
      Rectangle* pRect = !rect.HasValue ? (Rectangle*) null : &rect.Value;
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        uint elementSize = Helpers.GetSizeOf<T>();
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) elementSize));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.TextureCube.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, new UnsafeNativeStructures.TEXTURECUBE_COPYDATA_INFO((uint) level, cubeMapFace, elementSize, (uint) elementCount), pRect, (byte) 0));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void SetData<T>(CubeMapFace cubeMapFace, T[] data) where T : struct => this.SetData<T>(cubeMapFace, 0, new Rectangle?(), data, 0, data != null ? data.Length : 0);

    public void SetData<T>(CubeMapFace cubeMapFace, T[] data, int startIndex, int elementCount) where T : struct => this.SetData<T>(cubeMapFace, 0, new Rectangle?(), data, startIndex, elementCount);

    private static void ValidateParameters<T>(T[] data, int startIndex, int elementCount) where T : struct
    {
      if (data == null || data.Length == 0)
        throw new ArgumentNullException(nameof (data), FrameworkResources.ResourceDataMustBeCorrectSize);
      Helpers.ValidateCopyParameters(data.Length, startIndex, elementCount);
    }

    public int Size => this._size;

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.pComPtr == uint.MaxValue)
          return;
        UnsafeNativeMethods.TextureCube.GetGlobal(this._parent).ReleaseHandle(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr);
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
