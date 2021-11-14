// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.Texture2D
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Media;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class Texture2D : Texture
  {
    internal int _width;
    internal int _height;

    internal Texture2D()
    {
    }

    internal Texture2D(
      GraphicsDevice graphicsDevice,
      int width,
      int height,
      bool mipMap,
      SurfaceFormat format,
      bool isVideo)
    {
      this.CreateTexture(graphicsDevice, width, height, mipMap, format, isVideo);
    }

    public Texture2D(
      GraphicsDevice graphicsDevice,
      int width,
      int height,
      bool mipMap,
      SurfaceFormat format)
    {
      this.CreateTexture(graphicsDevice, width, height, mipMap, format, false);
    }

    public Texture2D(GraphicsDevice graphicsDevice, int width, int height) => this.CreateTexture(graphicsDevice, width, height, false, SurfaceFormat.Color, false);

    public static Texture2D FromStream(GraphicsDevice graphicsDevice, Stream stream) => new Texture2D(graphicsDevice, stream, graphicsDevice._profileCapabilities.MaxTextureSize, graphicsDevice._profileCapabilities.MaxTextureSize, XnaImageOperation.Nothing);

    public static Texture2D FromStream(
      GraphicsDevice graphicsDevice,
      Stream stream,
      int width,
      int height,
      bool zoom)
    {
      return new Texture2D(graphicsDevice, stream, width, height, zoom ? XnaImageOperation.Scale | XnaImageOperation.Crop : XnaImageOperation.Scale);
    }

    [SecuritySafeCritical]
    private Texture2D(
      GraphicsDevice graphicsDevice,
      Stream stream,
      int width,
      int height,
      XnaImageOperation operation)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      if (stream == null)
        throw new ArgumentNullException(nameof (stream));
      if (!stream.CanSeek)
        throw new ArgumentException(FrameworkResources.StreamNotSeekable, nameof (stream));
      Texture2D.ValidateCreationParameters(graphicsDevice._profileCapabilities, width, height, SurfaceFormat.Color, false);
      ImageStream imageStream = stream as ImageStream;
      try
      {
        if (imageStream == null)
          imageStream = ImageStream.FromStream(stream);
        if (imageStream.Handle == uint.MaxValue)
          throw new InvalidOperationException();
        uint texture = UnsafeNativeMethods.Imaging.DecodeStreamToTexture(graphicsDevice, imageStream.Handle, ref width, ref height, operation, graphicsDevice._profileCapabilities.MaxTextureAspectRatio, out this.pComPtr);
        if (texture == 2147942414U)
          throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
        GraphicsHelpers.ThrowExceptionFromResult(texture);
      }
      finally
      {
        if (imageStream != null && imageStream != stream)
          imageStream.Dispose();
      }
      this.InitializeDescription(graphicsDevice, SurfaceFormat.Color, 1U);
      this._width = width;
      this._height = height;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    internal void CreateTexture(
      GraphicsDevice graphicsDevice,
      int width,
      int height,
      bool mipMap,
      SurfaceFormat format,
      bool isVideo)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      Texture2D.ValidateCreationParameters(graphicsDevice._profileCapabilities, width, height, format, mipMap);
      uint levelCount;
      this.pComPtr = UnsafeNativeMethods.Texture2D.GetGlobal(graphicsDevice).CreateTexture(graphicsDevice.pComPtr, new UnsafeNativeStructures.TEXTURE_CREATION_PARAMS((uint) width, (uint) height, 0U, mipMap, format, isVideo ? 1 : 0), out levelCount);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this.InitializeDescription(graphicsDevice, format, levelCount);
      this._width = width;
      this._height = height;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    internal Texture2D(
      GraphicsDevice graphicsDevice,
      uint handle,
      UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters)
    {
      this.pComPtr = handle;
      this.InitializeDescription(graphicsDevice, parameters.dwFormat, parameters.dwLevels);
      this._width = (int) parameters.dwWidth;
      this._height = (int) parameters.dwHeight;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    internal static void ValidateCreationParameters(
      ProfileCapabilities profile,
      int width,
      int height,
      SurfaceFormat format,
      bool mipMap)
    {
      if (width <= 0)
        throw new ArgumentOutOfRangeException(nameof (width), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      if (height <= 0)
        throw new ArgumentOutOfRangeException(nameof (height), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      if (!profile.ValidTextureFormats.Contains(format))
        profile.ThrowNotSupportedException(FrameworkResources.ProfileFormatNotSupported, (object) typeof (Texture2D).Name, (object) format);
      if (width > profile.MaxTextureSize || height > profile.MaxTextureSize)
        profile.ThrowNotSupportedException(FrameworkResources.ProfileTooBig, (object) typeof (Texture2D).Name, (object) profile.MaxTextureSize);
      int num1 = Math.Max(width, height);
      int num2 = Math.Min(width, height);
      int num3 = num2;
      if ((num1 + num3 - 1) / num2 > profile.MaxTextureAspectRatio)
        profile.ThrowNotSupportedException(FrameworkResources.ProfileAspectRatio, (object) typeof (Texture2D).Name, (object) profile.MaxTextureAspectRatio);
      if (!profile.NonPow2Unconditional && (!Texture.IsPowerOfTwo(width) || !Texture.IsPowerOfTwo(height)))
      {
        if (mipMap)
          profile.ThrowNotSupportedException(FrameworkResources.ProfileNotPowerOfTwoMipped, (object) typeof (Texture2D).Name);
        if (Texture.IsCompressed(format))
          profile.ThrowNotSupportedException(FrameworkResources.ProfileNotPowerOfTwoDXT, (object) typeof (Texture2D).Name);
      }
      if (Texture.IsCompressed(format) && ((width & 3) != 0 || (height & 3) != 0))
        throw new ArgumentException(FrameworkResources.DxtNotMultipleOfFour);
    }

    [SecuritySafeCritical]
    public unsafe void GetData<T>(
      int level,
      Rectangle? rect,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      Texture2D.ValidateParameters<T>(data, startIndex, elementCount);
      if (this.isActiveRenderTarget)
        throw new InvalidOperationException(FrameworkResources.MustResolveRenderTarget);
      Rectangle* pRect = !rect.HasValue ? (Rectangle*) null : &rect.Value;
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        uint elementSize = Helpers.GetSizeOf<T>();
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) elementSize));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Texture2D.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, new UnsafeNativeStructures.TEXTURE_COPYDATA_INFO((uint) level, elementSize, (uint) elementCount), pRect, (byte) 1));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void GetData<T>(T[] data) where T : struct => this.GetData<T>(0, new Rectangle?(), data, 0, data != null ? data.Length : 0);

    public void GetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.GetData<T>(0, new Rectangle?(), data, startIndex, elementCount);

    [SecuritySafeCritical]
    public unsafe void SetData<T>(
      int level,
      Rectangle? rect,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      Texture2D.ValidateParameters<T>(data, startIndex, elementCount);
      if (this.isActiveRenderTarget)
        throw new InvalidOperationException(FrameworkResources.MustResolveRenderTarget);
      Rectangle* pRect = !rect.HasValue ? (Rectangle*) null : &rect.Value;
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        uint elementSize = Helpers.GetSizeOf<T>();
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) elementSize));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Texture2D.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, new UnsafeNativeStructures.TEXTURE_COPYDATA_INFO((uint) level, elementSize, (uint) elementCount), pRect, (byte) 0));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void SetData<T>(T[] data) where T : struct => this.SetData<T>(0, new Rectangle?(), data, 0, data != null ? data.Length : 0);

    public void SetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.SetData<T>(0, new Rectangle?(), data, startIndex, elementCount);

    private static void ValidateParameters<T>(T[] data, int startIndex, int elementCount) where T : struct
    {
      if (data == null || data.Length == 0)
        throw new ArgumentNullException(nameof (data), FrameworkResources.ResourceDataMustBeCorrectSize);
      Helpers.ValidateCopyParameters(data.Length, startIndex, elementCount);
    }

    public int Width => this._width;

    public int Height => this._height;

    public Rectangle Bounds
    {
      get
      {
        Rectangle rectangle;
        rectangle.X = 0;
        rectangle.Y = 0;
        rectangle.Width = this._width;
        rectangle.Height = this._height;
        return rectangle;
      }
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.pComPtr == uint.MaxValue)
          return;
        UnsafeNativeMethods.Texture2D.GetGlobal(this._parent).ReleaseHandle(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr);
        if (this._parent == null)
          return;
        this._parent.FireDestroyedEvent(this._name, this._tag, this.pComPtr);
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    public void SaveAsJpeg(Stream stream, int width, int height) => this.SaveAsImage(stream, XnaImageFormat.Jpeg, width, height);

    public void SaveAsPng(Stream stream, int width, int height) => this.SaveAsImage(stream, XnaImageFormat.Png, width, height);

    [SecuritySafeCritical]
    private void SaveAsImage(Stream stream, XnaImageFormat format, int width, int height)
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(nameof (Texture2D), FrameworkResources.ObjectDisposedException);
      if (!stream.CanWrite)
        throw new ArgumentException(nameof (stream));
      if (format != XnaImageFormat.Jpeg && format != XnaImageFormat.Png)
        throw new ArgumentException(nameof (format));
      Color[] colorArray;
      switch (this.Format)
      {
        case SurfaceFormat.Color:
          colorArray = new Color[this.Width * this.Height];
          this.GetData<Color>(colorArray);
          break;
        case SurfaceFormat.Bgr565:
          colorArray = this.GetDataAsColor<Bgr565>();
          break;
        case SurfaceFormat.Bgra5551:
          colorArray = this.GetDataAsColor<Bgra5551>();
          break;
        case SurfaceFormat.Bgra4444:
          colorArray = this.GetDataAsColor<Bgra4444>();
          break;
        case SurfaceFormat.Dxt1:
        case SurfaceFormat.Dxt3:
        case SurfaceFormat.Dxt5:
          DxtDecoder dxtDecoder = new DxtDecoder(this.Width, this.Height, this.Format);
          byte[] numArray = new byte[dxtDecoder.PackedDataSize];
          this.GetData<byte>(numArray);
          colorArray = dxtDecoder.Decode(numArray);
          break;
        case SurfaceFormat.NormalizedByte2:
          colorArray = this.GetDataAsColor<NormalizedByte2>();
          break;
        case SurfaceFormat.NormalizedByte4:
          colorArray = this.GetDataAsColor<NormalizedByte4>();
          break;
        case SurfaceFormat.Rgba1010102:
          colorArray = this.GetDataAsColor<Rgba1010102>();
          break;
        case SurfaceFormat.Rg32:
          colorArray = this.GetDataAsColor<Rg32>();
          break;
        case SurfaceFormat.Rgba64:
          colorArray = this.GetDataAsColor<Rgba64>();
          break;
        case SurfaceFormat.Alpha8:
          colorArray = this.GetDataAsColor<Alpha8>();
          break;
        case SurfaceFormat.Single:
          colorArray = this.GetDataAsColor<float>((Converter<float, Color>) (v => new Color(v, 0.0f, 0.0f, 1f)));
          break;
        case SurfaceFormat.Vector2:
          colorArray = this.GetDataAsColor<Vector2>((Converter<Vector2, Color>) (v => new Color(v.X, v.Y, 0.0f, 1f)));
          break;
        case SurfaceFormat.Vector4:
          colorArray = this.GetDataAsColor<Vector4>((Converter<Vector4, Color>) (v => new Color(v)));
          break;
        case SurfaceFormat.HalfSingle:
          colorArray = this.GetDataAsColor<HalfSingle>();
          break;
        case SurfaceFormat.HalfVector2:
          colorArray = this.GetDataAsColor<HalfVector2>();
          break;
        case SurfaceFormat.HalfVector4:
          colorArray = this.GetDataAsColor<HalfVector4>();
          break;
        case SurfaceFormat.HdrBlendable:
          colorArray = this.GetDataAsColor<HalfVector4>();
          break;
        default:
          throw new InvalidOperationException();
      }
      for (int index = 0; index < colorArray.Length; ++index)
      {
        if (colorArray[index].A == (byte) 0)
          colorArray[index] = Color.Transparent;
      }
      using (ImageStream imageStream = ImageStream.FromColors(colorArray, this.Width, this.Height, format, width, height))
      {
        byte[] buffer = new BinaryReader((Stream) imageStream).ReadBytes((int) imageStream.Length);
        stream.Write(buffer, 0, buffer.Length);
      }
    }

    private Color[] GetDataAsColor<T>() where T : struct, IPackedVector => this.GetDataAsColor<T>((Converter<T, Color>) (v => new Color(v.ToVector4())));

    private Color[] GetDataAsColor<T>(Converter<T, Color> toColor) where T : struct
    {
      int length = this.Width * this.Height;
      T[] data = new T[length];
      this.GetData<T>(data);
      Color[] colorArray = new Color[length];
      for (int index = 0; index < length; ++index)
        colorArray[index] = toColor(data[index]);
      return colorArray;
    }
  }
}
