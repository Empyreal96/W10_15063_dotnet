// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.VertexBuffer
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class VertexBuffer : GraphicsResource
  {
    internal BufferUsage _usage;
    internal int _size;
    internal int _vertexCount;
    internal VertexDeclaration _vertexDeclaration;

    public VertexBuffer(
      GraphicsDevice graphicsDevice,
      VertexDeclaration vertexDeclaration,
      int vertexCount,
      BufferUsage usage)
    {
      if (vertexDeclaration == null)
        throw new ArgumentNullException(nameof (vertexDeclaration), FrameworkResources.NullNotAllowed);
      if (vertexCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (vertexCount), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      this.CreateBuffer(graphicsDevice, vertexDeclaration, vertexCount, usage, 0);
    }

    public VertexBuffer(
      GraphicsDevice graphicsDevice,
      Type vertexType,
      int vertexCount,
      BufferUsage usage)
    {
      VertexDeclaration vertexDeclaration = VertexDeclaration.FromType(vertexType);
      if (vertexCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (vertexCount), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      this.CreateBuffer(graphicsDevice, vertexDeclaration, vertexCount, usage, 0);
    }

    internal VertexBuffer()
    {
    }

    internal void CreateBuffer(
      GraphicsDevice graphicsDevice,
      VertexDeclaration vertexDeclaration,
      int vertexCount,
      BufferUsage usage,
      int isDynamic)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      if (vertexDeclaration._isDisposed)
        throw new ObjectDisposedException(typeof (VertexDeclaration).Name);
      if (vertexDeclaration.GraphicsDevice != graphicsDevice)
        vertexDeclaration.Bind(graphicsDevice);
      int num = vertexDeclaration._vertexStride * vertexCount;
      if (num > graphicsDevice._profileCapabilities.MaxVertexBufferSize)
        graphicsDevice._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileTooBig, (object) typeof (VertexBuffer).Name, (object) graphicsDevice._profileCapabilities.MaxVertexBufferSize);
      this.pComPtr = UnsafeNativeMethods.VertexBuffer.GetGlobal(graphicsDevice).CreateVertexBuffer(graphicsDevice.pComPtr, (uint) num, isDynamic);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._parent = graphicsDevice;
      this._usage = usage;
      this._size = num;
      this._vertexCount = vertexCount;
      this._vertexDeclaration = vertexDeclaration;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    public BufferUsage BufferUsage => this._usage;

    public int VertexCount => this._vertexCount;

    public VertexDeclaration VertexDeclaration => this._vertexDeclaration;

    [SecuritySafeCritical]
    public unsafe void GetData<T>(
      int offsetInBytes,
      T[] data,
      int startIndex,
      int elementCount,
      int vertexStride)
      where T : struct
    {
      int num = this.ValidateParameters<T>(offsetInBytes, data, startIndex, elementCount, ref vertexStride);
      if ((this._usage & BufferUsage.WriteOnly) == BufferUsage.WriteOnly)
        throw new NotSupportedException(FrameworkResources.WriteOnlyGetNotSupported);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + startIndex * num);
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.VertexBuffer.GetGlobal(this.GraphicsDevice).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, (uint) offsetInBytes, new UnsafeNativeStructures.VERTEX_COPYDATA_INFO((uint) vertexStride, (uint) elementCount, (uint) num, 0U), (byte) 1));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void GetData<T>(T[] data) where T : struct => this.GetData<T>(0, data, 0, data != null ? data.Length : 0, 0);

    public void GetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.GetData<T>(0, data, startIndex, elementCount, 0);

    [SecuritySafeCritical]
    public unsafe void SetData<T>(
      int offsetInBytes,
      T[] data,
      int startIndex,
      int elementCount,
      int vertexStride)
      where T : struct
    {
      int num = this.ValidateParameters<T>(offsetInBytes, data, startIndex, elementCount, ref vertexStride);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + startIndex * num);
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.VertexBuffer.GetGlobal(this.GraphicsDevice).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, (uint) offsetInBytes, new UnsafeNativeStructures.VERTEX_COPYDATA_INFO((uint) vertexStride, (uint) elementCount, (uint) num, 0U), (byte) 0));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void SetData<T>(T[] data) where T : struct => this.SetData<T>(0, data, 0, data != null ? data.Length : 0, 0);

    public void SetData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.SetData<T>(0, data, startIndex, elementCount, 0);

    internal int ValidateParameters<T>(
      int offsetInBytes,
      T[] data,
      int startIndex,
      int elementCount,
      ref int vertexStride)
      where T : struct
    {
      if (data == null || data.Length == 0)
        throw new ArgumentNullException(nameof (data), FrameworkResources.ResourceDataMustBeCorrectSize);
      Helpers.ValidateCopyParameters(data.Length, startIndex, elementCount);
      int num1 = (int) Helpers.GetSizeOf<T>();
      int num2 = num1 * elementCount;
      if (vertexStride == 0)
      {
        vertexStride = num1;
      }
      else
      {
        int num3 = vertexStride - num1;
        if (num3 < 0)
          throw new ArgumentOutOfRangeException(nameof (vertexStride), FrameworkResources.VertexStrideTooSmall);
        if (elementCount > 1)
          num2 += num3 * (elementCount - 1);
      }
      if (num2 + offsetInBytes > this._size)
        throw new InvalidOperationException(FrameworkResources.ResourceDataMustBeCorrectSize);
      return num1;
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.pComPtr == uint.MaxValue)
          return;
        UnsafeNativeMethods.VertexBuffer.GetGlobal(this._parent).ReleaseHandle(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr);
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
