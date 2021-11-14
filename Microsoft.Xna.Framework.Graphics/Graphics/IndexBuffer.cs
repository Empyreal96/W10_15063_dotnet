// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.IndexBuffer
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class IndexBuffer : GraphicsResource
  {
    internal int _indexCount;
    internal int _indexSize;
    internal int _bufferSize;
    internal BufferUsage _usage;

    public IndexBuffer(
      GraphicsDevice graphicsDevice,
      IndexElementSize indexElementSize,
      int indexCount,
      BufferUsage usage)
    {
      int indexSize = indexElementSize == IndexElementSize.SixteenBits ? 2 : 4;
      this.CreateBuffer(graphicsDevice, indexCount, indexSize, usage, 0);
    }

    [SecuritySafeCritical]
    public IndexBuffer(
      GraphicsDevice graphicsDevice,
      Type indexType,
      int indexCount,
      BufferUsage usage)
    {
      int indexSize = Marshal.SizeOf(indexType);
      this.CreateBuffer(graphicsDevice, indexCount, indexSize, usage, 0);
    }

    internal IndexBuffer()
    {
    }

    internal void CreateBuffer(
      GraphicsDevice graphicsDevice,
      int indexCount,
      int indexSize,
      BufferUsage usage,
      int isDynamic)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      if (indexCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (indexCount), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      if (indexSize != 2)
      {
        if (indexSize != 4)
          throw new ArgumentException(FrameworkResources.IndexBuffersMustBeSizedCorrectly);
        if (!graphicsDevice._profileCapabilities.IndexElementSize32)
          graphicsDevice._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoIndexElementSize32);
      }
      this._bufferSize = indexCount * indexSize;
      if (this._bufferSize > graphicsDevice._profileCapabilities.MaxIndexBufferSize)
        graphicsDevice._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileTooBig, (object) typeof (IndexBuffer).Name, (object) graphicsDevice._profileCapabilities.MaxIndexBufferSize);
      this.pComPtr = UnsafeNativeMethods.IndexBuffer.GetGlobal(graphicsDevice).CreateIndexBuffer(graphicsDevice.pComPtr, (uint) this._bufferSize, indexSize == 2 ? 1 : 0, isDynamic);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._usage = usage;
      this._indexCount = indexCount;
      this._indexSize = indexSize;
      this._parent = graphicsDevice;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    public IndexElementSize IndexElementSize => this._indexSize != 2 ? IndexElementSize.ThirtyTwoBits : IndexElementSize.SixteenBits;

    public BufferUsage BufferUsage => this._usage;

    public int IndexCount => this._indexCount;

    [SecuritySafeCritical]
    public unsafe void GetData<T>(int offsetInBytes, T[] data, int startIndex, int elementCount) where T : struct
    {
      uint datasize = this.ValidateParameters<T>(offsetInBytes, data, startIndex, elementCount);
      if ((this._usage & BufferUsage.WriteOnly) == BufferUsage.WriteOnly)
        throw new NotSupportedException(FrameworkResources.WriteOnlyGetNotSupported);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) Helpers.GetSizeOf<T>()));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.IndexBuffer.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, datasize, (uint) offsetInBytes, 0U, (byte) 1));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void GetData<T>(T[] data) where T : struct => this.GetData<T>(0, data, 0, data != null ? data.Length : 0);

    public void GetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.GetData<T>(0, data, startIndex, elementCount);

    [SecuritySafeCritical]
    public unsafe void SetData<T>(int offsetInBytes, T[] data, int startIndex, int elementCount) where T : struct
    {
      uint datasize = this.ValidateParameters<T>(offsetInBytes, data, startIndex, elementCount);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) Helpers.GetSizeOf<T>()));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.IndexBuffer.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, datasize, (uint) offsetInBytes, 0U, (byte) 0));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void SetData<T>(T[] data) where T : struct => this.SetData<T>(0, data, 0, data != null ? data.Length : 0);

    public void SetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.SetData<T>(0, data, startIndex, elementCount);

    internal uint ValidateParameters<T>(
      int offsetInBytes,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      if (data == null || data.Length == 0)
        throw new ArgumentNullException(nameof (data), FrameworkResources.ResourceDataMustBeCorrectSize);
      Helpers.ValidateCopyParameters(data.Length, startIndex, elementCount);
      int num;
      if ((long) (num = (int) Helpers.GetSizeOf<T>() * elementCount) + (long) offsetInBytes <= (long) this._bufferSize)
        return (uint) num;
      throw new InvalidOperationException(FrameworkResources.ResourceDataMustBeCorrectSize);
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.pComPtr == uint.MaxValue)
          return;
        UnsafeNativeMethods.IndexBuffer.GetGlobal(this._parent).ReleaseHandle(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr);
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
