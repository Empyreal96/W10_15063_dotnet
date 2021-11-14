// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DynamicVertexBuffer
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class DynamicVertexBuffer : VertexBuffer
  {
    public DynamicVertexBuffer(
      GraphicsDevice graphicsDevice,
      VertexDeclaration vertexDeclaration,
      int vertexCount,
      BufferUsage usage)
    {
      if (vertexDeclaration == null)
        throw new ArgumentNullException(nameof (vertexDeclaration), FrameworkResources.NullNotAllowed);
      if (vertexCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (vertexCount), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      this.CreateBuffer(graphicsDevice, vertexDeclaration, vertexCount, usage, 1);
    }

    public DynamicVertexBuffer(
      GraphicsDevice graphicsDevice,
      Type vertexType,
      int vertexCount,
      BufferUsage usage)
    {
      VertexDeclaration vertexDeclaration = VertexDeclaration.FromType(vertexType);
      if (vertexCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (vertexCount), FrameworkResources.ResourcesMustBeGreaterThanZeroSize);
      this.CreateBuffer(graphicsDevice, vertexDeclaration, vertexCount, usage, 1);
    }

    [SecuritySafeCritical]
    public unsafe void SetData<T>(
      int offsetInBytes,
      T[] data,
      int startIndex,
      int elementCount,
      int vertexStride,
      SetDataOptions options)
      where T : struct
    {
      int num = this.ValidateParameters<T>(offsetInBytes, data, startIndex, elementCount, ref vertexStride);
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + startIndex * num);
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.VertexBuffer.GetGlobal(this.GraphicsDevice).CopyData(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr, (void*) numPtr, (uint) offsetInBytes, new UnsafeNativeStructures.VERTEX_COPYDATA_INFO((uint) vertexStride, (uint) elementCount, (uint) num, (uint) options), (byte) 0));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void SetData<T>(T[] data, int startIndex, int elementCount, SetDataOptions options) where T : struct => this.SetData<T>(0, data, startIndex, elementCount, 0, options);

    public bool IsContentLost => false;

    public event EventHandler<EventArgs> ContentLost;
  }
}
