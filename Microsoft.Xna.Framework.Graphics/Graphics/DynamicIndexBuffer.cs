// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DynamicIndexBuffer
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class DynamicIndexBuffer : IndexBuffer
  {
    public DynamicIndexBuffer(
      GraphicsDevice graphicsDevice,
      IndexElementSize indexElementSize,
      int indexCount,
      BufferUsage usage)
    {
      int indexSize = indexElementSize == IndexElementSize.SixteenBits ? 2 : 4;
      this.CreateBuffer(graphicsDevice, indexCount, indexSize, usage, 1);
    }

    [SecuritySafeCritical]
    public DynamicIndexBuffer(
      GraphicsDevice graphicsDevice,
      Type indexType,
      int indexCount,
      BufferUsage usage)
    {
      int indexSize = Marshal.SizeOf(indexType);
      this.CreateBuffer(graphicsDevice, indexCount, indexSize, usage, 1);
    }

    [SecuritySafeCritical]
    public unsafe void SetData<T>(
      int offsetInBytes,
      T[] data,
      int startIndex,
      int elementCount,
      SetDataOptions options)
      where T : struct
    {
      uint datasize = this.ValidateParameters<T>(offsetInBytes, data, startIndex, elementCount);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) Helpers.GetSizeOf<T>()));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.IndexBuffer.GetGlobal(this._parent).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, datasize, (uint) offsetInBytes, (uint) options, (byte) 0));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void SetData<T>(T[] data, int startIndex, int elementCount, SetDataOptions options) where T : struct => this.SetData<T>(0, data, startIndex, elementCount, options);

    public bool IsContentLost => false;

    public event EventHandler<EventArgs> ContentLost;
  }
}
