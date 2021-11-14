// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.UnsafeNativeMethods
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class UnsafeNativeMethods
  {
    private const string DllName = "XnaFrameworkCore";
    private const string MediaDllName = "XnaFrameworkCore";

    public static class Adapter
    {
      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_GetCurrentDisplayMode")]
      public static extern uint GetCurrentDisplayMode(
        uint handle,
        out UnsafeNativeStructures.DISPLAY_MODE_INFO mode,
        out uint widescreen);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_GetSupportedDisplayMode")]
      public static extern uint GetSupportedDisplayMode(
        uint handle,
        uint index,
        out UnsafeNativeStructures.DISPLAY_MODE_INFO mode);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_IsProfileSupported")]
      public static extern uint IsProfileSupported(uint handle, GraphicsProfile profile);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_QueryFormat")]
      public static extern uint QueryFormat(
        uint handle,
        bool isBackBuffer,
        GraphicsProfile profile,
        ref UnsafeNativeStructures.QUERY_FORMAT_INFO info);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_CreateDirect3DHandle")]
      public static extern uint CreateHandle(out UnsafeNativeStructures.ADAPTER_DESC desc);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_ReleaseHandle")]
      public static extern void ReleaseHandle(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_CreateDeviceHandle")]
      public static extern uint CreateDevice(
        uint handle,
        ref PresentationParameters.Settings pp,
        GraphicsProfile profile);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_GetLastErrorDetails")]
      public static extern uint GetLastErrorDetails(
        uint expectedHr,
        out uint data1,
        out uint data2);
    }

    public class Device
    {
      private static UnsafeNativeMethods.Device _global;

      private Device()
      {
      }

      public static UnsafeNativeMethods.Device GetGlobal(GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.Device._global == null)
          UnsafeNativeMethods.Device._global = new UnsafeNativeMethods.Device();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.Device._global;
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public void ReleaseHandle(uint handle) => UnsafeNativeMethods.Device.InteropReleaseHandle(handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint Present(uint handle) => UnsafeNativeMethods.Device.InteropPresent(handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CreateRenderTarget(
        uint handle,
        UnsafeNativeStructures.D3D_RENDERTARGET_CREATION_PARAMS creation,
        bool cubeTexure,
        out uint textureHandle,
        out uint textureLevelCount)
      {
        return UnsafeNativeMethods.Device.InteropCreateRenderTarget(handle, creation, cubeTexure ? uint.MaxValue : 0U, out textureHandle, out textureLevelCount);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint GetScissorRect(uint handle, out Rectangle rect) => UnsafeNativeMethods.Device.InteropGetScissorRect(handle, out rect);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint GetTexture(
        uint handle,
        uint sampler,
        out TextureType textureType,
        out UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters)
      {
        return UnsafeNativeMethods.Device.InteropGetTexture(handle, sampler, out textureType, out parameters);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public unsafe uint DrawUserPrims(
        uint handle,
        PrimitiveType primitiveType,
        uint primitiveCount,
        void* pVertexData,
        uint vertexSize,
        uint vertexStride)
      {
        return UnsafeNativeMethods.Device.InteropDrawUserPrims(handle, primitiveType, primitiveCount, pVertexData, vertexSize, vertexStride);
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint DrawUserPrims(
        uint handle,
        PrimitiveType primitiveType,
        UnsafeNativeStructures.DUIP_PARAMS dp)
      {
        return UnsafeNativeMethods.Device.InteropDrawUserPrims(handle, primitiveType, dp);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public unsafe uint DrawSprites(
        uint handle,
        int spriteCount,
        void* pSpriteData,
        int textureWidth,
        int textureHeight)
      {
        return UnsafeNativeMethods.Device.InteropDrawSprites(handle, spriteCount, pSpriteData, textureWidth, textureHeight);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint Reset(uint handle, ref PresentationParameters.Settings pp) => UnsafeNativeMethods.Device.InteropReset(handle, ref pp);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public void ReleaseRenderTargetHandle(uint handle, uint renderTargetHandle) => UnsafeNativeMethods.Device.InteropReleaseRenderTargetHandle(handle, renderTargetHandle);

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint CreateBlendState(uint deviceHandle, ref BlendState.Settings settings) => UnsafeNativeMethods.Device.InteropCreateBlendState(deviceHandle, ref settings);

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseBlendState(uint handle) => UnsafeNativeMethods.Device.InteropReleaseBlendState(handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CreateDepthStencilState(
        uint deviceHandle,
        ref DepthStencilState.Settings settings)
      {
        return UnsafeNativeMethods.Device.InteropCreateDepthStencilState(deviceHandle, ref settings);
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public void ReleaseDepthStencilState(uint handle) => UnsafeNativeMethods.Device.InteropReleaseDepthStencilState(handle);

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint CreateRasterizerState(uint deviceHandle, ref RasterizerState.Settings settings) => UnsafeNativeMethods.Device.InteropCreateRasterizerState(deviceHandle, ref settings);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public void ReleaseRasterizerState(uint handle) => UnsafeNativeMethods.Device.InteropReleaseRasterizerState(handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CreateSamplerState(uint deviceHandle, ref SamplerState.Settings settings) => UnsafeNativeMethods.Device.InteropCreateSamplerState(deviceHandle, ref settings);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public void ReleaseSamplerState(uint handle) => UnsafeNativeMethods.Device.InteropReleaseSamplerState(handle);

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public unsafe uint GetBackBufferData(
        uint handle,
        void* pData,
        UnsafeNativeStructures.TEXTURE_COPYDATA_INFO data,
        Rectangle* pRect)
      {
        return UnsafeNativeMethods.Device.InteropGetBackBufferData(handle, pData, data, pRect);
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_Reset")]
      private static extern uint InteropReset(uint handle, ref PresentationParameters.Settings pp);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_Present")]
      private static extern uint InteropPresent(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_ReceivePackets")]
      public static extern unsafe uint SendHLCBPacket(
        uint handle,
        byte* pPacketData,
        uint packetSize);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_CreateRenderTarget")]
      private static extern uint InteropCreateRenderTarget(
        uint handle,
        UnsafeNativeStructures.D3D_RENDERTARGET_CREATION_PARAMS creation,
        uint cubeTexure,
        out uint textureHandle,
        out uint textureLevelCount);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_GetScissorRect")]
      private static extern uint InteropGetScissorRect(uint handle, out Rectangle rect);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_DrawPrimitivesUP")]
      private static extern unsafe uint InteropDrawUserPrims(
        uint handle,
        PrimitiveType primitiveType,
        uint primitiveCount,
        void* pVertexData,
        uint vertexSize,
        uint vertexStride);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_DrawIndexedPrimitivesUP")]
      private static extern uint InteropDrawUserPrims(
        uint handle,
        PrimitiveType primitiveType,
        UnsafeNativeStructures.DUIP_PARAMS duip);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_DrawSprites")]
      private static extern unsafe uint InteropDrawSprites(
        uint handle,
        int spriteCount,
        void* pSpriteData,
        int textureWidth,
        int textureHeight);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Texture_GetTexture")]
      private static extern uint InteropGetTexture(
        uint handle,
        uint sampler,
        out TextureType textureType,
        out UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_ReleaseRenderTarget")]
      private static extern void InteropReleaseRenderTargetHandle(
        uint handle,
        uint renderTargetHandle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_CreateBlendState")]
      private static extern uint InteropCreateBlendState(
        uint deviceHandle,
        ref BlendState.Settings settings);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_ReleaseBlendState")]
      private static extern void InteropReleaseBlendState(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_CreateDepthStencilState")]
      private static extern uint InteropCreateDepthStencilState(
        uint deviceHandle,
        ref DepthStencilState.Settings settings);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_ReleaseDepthStencilState")]
      private static extern void InteropReleaseDepthStencilState(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_CreateRasterizerState")]
      private static extern uint InteropCreateRasterizerState(
        uint deviceHandle,
        ref RasterizerState.Settings settings);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_ReleaseRasterizerState")]
      private static extern void InteropReleaseRasterizerState(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_CreateSamplerState")]
      private static extern uint InteropCreateSamplerState(
        uint deviceHandle,
        ref SamplerState.Settings settings);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_ReleaseSamplerState")]
      private static extern void InteropReleaseSamplerState(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Device_GetBackBufferData")]
      private static extern unsafe uint InteropGetBackBufferData(
        uint handle,
        void* pData,
        UnsafeNativeStructures.TEXTURE_COPYDATA_INFO data,
        Rectangle* pRect);
    }

    public class VertexDeclaration
    {
      private static UnsafeNativeMethods.VertexDeclaration _global;

      private VertexDeclaration()
      {
      }

      public static UnsafeNativeMethods.VertexDeclaration GetGlobal(
        GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.VertexDeclaration._global == null)
          UnsafeNativeMethods.VertexDeclaration._global = new UnsafeNativeMethods.VertexDeclaration();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.VertexDeclaration._global;
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.VertexDeclaration.InteropReleaseHandle(deviceHandle, handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public unsafe uint CreateHandle(uint deviceHandle, void* pElements, uint elementCount) => UnsafeNativeMethods.VertexDeclaration.InteropCreateHandle(deviceHandle, pElements, elementCount);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Decl_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Decl_CreateHandle")]
      private static extern unsafe uint InteropCreateHandle(
        uint deviceHandle,
        void* pElements,
        uint elementCount);
    }

    public class VertexBuffer
    {
      private static UnsafeNativeMethods.VertexBuffer _global;

      private VertexBuffer()
      {
      }

      public static UnsafeNativeMethods.VertexBuffer GetGlobal(GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.VertexBuffer._global == null)
          UnsafeNativeMethods.VertexBuffer._global = new UnsafeNativeMethods.VertexBuffer();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.VertexBuffer._global;
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.VertexBuffer.InteropReleaseHandle(deviceHandle, handle);

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint CreateVertexBuffer(uint deviceHandle, uint size, int isDynamic) => UnsafeNativeMethods.VertexBuffer.InteropCreateVertexBuffer(deviceHandle, size, isDynamic);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public unsafe uint CopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        uint offset,
        UnsafeNativeStructures.VERTEX_COPYDATA_INFO copyInfo,
        byte read)
      {
        return UnsafeNativeMethods.VertexBuffer.InteropCopyData(deviceHandle, handle, pData, offset, copyInfo, read);
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_VertexBuffer_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_VertexBuffer_CreateHandle")]
      private static extern uint InteropCreateVertexBuffer(
        uint deviceHandle,
        uint size,
        int isDynamic);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_VertexBuffer_CopyData")]
      private static extern unsafe uint InteropCopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        uint offset,
        UnsafeNativeStructures.VERTEX_COPYDATA_INFO copyInfo,
        byte read);
    }

    public class IndexBuffer
    {
      private static UnsafeNativeMethods.IndexBuffer _global;

      private IndexBuffer()
      {
      }

      public static UnsafeNativeMethods.IndexBuffer GetGlobal(GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.IndexBuffer._global == null)
          UnsafeNativeMethods.IndexBuffer._global = new UnsafeNativeMethods.IndexBuffer();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.IndexBuffer._global;
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.IndexBuffer.InteropReleaseHandle(deviceHandle, handle);

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint CreateIndexBuffer(uint deviceHandle, uint size, int sixteenbit, int isDynamic) => UnsafeNativeMethods.IndexBuffer.InteropCreateIndexBuffer(deviceHandle, size, sixteenbit, isDynamic);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public unsafe uint CopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        uint datasize,
        uint offset,
        uint options,
        byte read)
      {
        return UnsafeNativeMethods.IndexBuffer.InteropCopyData(deviceHandle, handle, pData, datasize, offset, options, read);
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_IndexBuffer_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_IndexBuffer_CreateHandle")]
      private static extern uint InteropCreateIndexBuffer(
        uint deviceHandle,
        uint size,
        int sixteenbit,
        int isDynamic);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_IndexBuffer_CopyData")]
      private static extern unsafe uint InteropCopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        uint datasize,
        uint offset,
        uint options,
        byte read);
    }

    public class Texture2D
    {
      private static UnsafeNativeMethods.Texture2D _global;

      private Texture2D()
      {
      }

      public static UnsafeNativeMethods.Texture2D GetGlobal(GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.Texture2D._global == null)
          UnsafeNativeMethods.Texture2D._global = new UnsafeNativeMethods.Texture2D();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.Texture2D._global;
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.Texture2D.InteropReleaseHandle(deviceHandle, handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CreateTexture(
        uint deviceHandle,
        UnsafeNativeStructures.TEXTURE_CREATION_PARAMS creation,
        out uint levelCount)
      {
        return UnsafeNativeMethods.Texture2D.InteropCreateTexture(deviceHandle, creation, out levelCount);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public unsafe uint CopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        UnsafeNativeStructures.TEXTURE_COPYDATA_INFO data,
        Rectangle* pRect,
        byte read)
      {
        return UnsafeNativeMethods.Texture2D.InteropCopyData(deviceHandle, handle, pData, data, pRect, read);
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Texture2D_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Texture2D_CreateHandle")]
      private static extern uint InteropCreateTexture(
        uint deviceHandle,
        UnsafeNativeStructures.TEXTURE_CREATION_PARAMS creation,
        out uint levelCount);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Texture2D_CopyData")]
      private static extern unsafe uint InteropCopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        UnsafeNativeStructures.TEXTURE_COPYDATA_INFO data,
        Rectangle* pRect,
        byte read);
    }

    public class TextureCube
    {
      private static UnsafeNativeMethods.TextureCube _global;

      private TextureCube()
      {
      }

      public static UnsafeNativeMethods.TextureCube GetGlobal(GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.TextureCube._global == null)
          UnsafeNativeMethods.TextureCube._global = new UnsafeNativeMethods.TextureCube();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.TextureCube._global;
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.TextureCube.InteropReleaseHandle(deviceHandle, handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CreateTexture(
        uint deviceHandle,
        UnsafeNativeStructures.TEXTURE_CREATION_PARAMS creation,
        out uint levelCount)
      {
        return UnsafeNativeMethods.TextureCube.InteropCreateTexture(deviceHandle, creation, out levelCount);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public unsafe uint CopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        UnsafeNativeStructures.TEXTURECUBE_COPYDATA_INFO data,
        Rectangle* pRect,
        byte read)
      {
        return UnsafeNativeMethods.TextureCube.InteropCopyData(deviceHandle, handle, pData, data, pRect, read);
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_TextureCube_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_TextureCube_CreateHandle")]
      private static extern uint InteropCreateTexture(
        uint deviceHandle,
        UnsafeNativeStructures.TEXTURE_CREATION_PARAMS creation,
        out uint levelCount);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_TextureCube_CopyData")]
      private static extern unsafe uint InteropCopyData(
        uint deviceHandle,
        uint handle,
        void* pData,
        UnsafeNativeStructures.TEXTURECUBE_COPYDATA_INFO data,
        Rectangle* pRect,
        byte read);
    }

    public class Texture3D
    {
      private static UnsafeNativeMethods.Texture3D _global;

      private Texture3D()
      {
      }

      public static UnsafeNativeMethods.Texture3D GetGlobal(GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.Texture3D._global == null)
          UnsafeNativeMethods.Texture3D._global = new UnsafeNativeMethods.Texture3D();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.Texture3D._global;
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.Texture3D.InteropReleaseHandle(deviceHandle, handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CreateTexture(
        uint deviceHandle,
        UnsafeNativeStructures.TEXTURE_CREATION_PARAMS creation,
        out uint levelCount)
      {
        return UnsafeNativeMethods.Texture3D.InteropCreateTexture(deviceHandle, creation, out levelCount);
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CopyData(
        uint deviceHandle,
        uint handle,
        ref UnsafeNativeStructures.TEXTURE3D_COPYDATA_INFO data,
        byte read)
      {
        return UnsafeNativeMethods.Texture3D.InteropCopyData(deviceHandle, handle, ref data, read);
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Texture3D_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Texture3D_CreateHandle")]
      private static extern uint InteropCreateTexture(
        uint deviceHandle,
        UnsafeNativeStructures.TEXTURE_CREATION_PARAMS creation,
        out uint levelCount);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Texture3D_CopyData")]
      private static extern uint InteropCopyData(
        uint deviceHandle,
        uint handle,
        ref UnsafeNativeStructures.TEXTURE3D_COPYDATA_INFO data,
        byte read);
    }

    public class Effect
    {
      private static UnsafeNativeMethods.Effect _global;

      private Effect()
      {
      }

      public static UnsafeNativeMethods.Effect GetGlobal(GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.Effect._global == null)
          UnsafeNativeMethods.Effect._global = new UnsafeNativeMethods.Effect();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.Effect._global;
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.Effect.InteropReleaseHandle(deviceHandle, handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public unsafe uint CreateEffect(
        void* pEffectCode,
        uint shaderCodeSize,
        uint deviceHandle,
        out UnsafeNativeStructures.EFFECT_DESC desc)
      {
        return UnsafeNativeMethods.Effect.InteropCreateEffect(pEffectCode, shaderCodeSize, deviceHandle, out desc);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint CloneEffect(
        uint deviceHandle,
        uint effectHandle,
        out UnsafeNativeStructures.EFFECT_DESC desc)
      {
        return UnsafeNativeMethods.Effect.InteropCloneEffect(deviceHandle, effectHandle, out desc);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public uint GetTechnique(
        uint deviceHandle,
        uint handle,
        uint index,
        out UnsafeNativeStructures.EFFECT_TECHNIQUE_DESC desc,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sb)
      {
        return UnsafeNativeMethods.Effect.InteropGetTechnique(deviceHandle, handle, index, out desc, sb);
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint GetPass(
        uint deviceHandle,
        uint handle,
        uint techniqueHandle,
        uint index,
        out UnsafeNativeStructures.EFFECT_PASS_DESC desc,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sb)
      {
        return UnsafeNativeMethods.Effect.InteropGetPass(deviceHandle, handle, techniqueHandle, index, out desc, sb);
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint GetParameter(
        uint deviceHandle,
        UnsafeNativeStructures.D3DXPARAM_INPUT input,
        out UnsafeNativeStructures.EFFECT_PARAMETER_DESC desc,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder name,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder semantic)
      {
        return UnsafeNativeMethods.Effect.InteropGetParameter(deviceHandle, input, out desc, name, semantic);
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public unsafe uint GetValue(
        uint deviceHandle,
        uint effectHandle,
        uint paramHandle,
        GetShaderValueType dataType,
        void* pData,
        uint dataSize,
        uint arrayCount)
      {
        return UnsafeNativeMethods.Effect.InteropGetValue(deviceHandle, effectHandle, paramHandle, dataType, pData, dataSize, arrayCount);
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint GetValueString(
        uint deviceHandle,
        uint effectHandle,
        uint paramHandle,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sb)
      {
        return UnsafeNativeMethods.Effect.InteropGetValueString(deviceHandle, effectHandle, paramHandle, sb);
      }

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint GetTexture(
        uint deviceHandle,
        uint effectHandle,
        uint paramHandle,
        out uint textureHandle,
        out TextureType textureType,
        out UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters)
      {
        return UnsafeNativeMethods.Effect.InteropGetTexture(deviceHandle, effectHandle, paramHandle, out textureHandle, out textureType, out parameters);
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_CreateHandle")]
      private static extern unsafe uint InteropCreateEffect(
        void* pEffectCode,
        uint shaderCodeSize,
        uint deviceHandle,
        out UnsafeNativeStructures.EFFECT_DESC desc);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_CloneEffect")]
      private static extern uint InteropCloneEffect(
        uint deviceHandle,
        uint effectHandle,
        out UnsafeNativeStructures.EFFECT_DESC desc);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_GetTechnique")]
      private static extern uint InteropGetTechnique(
        uint deviceHandle,
        uint handle,
        uint index,
        out UnsafeNativeStructures.EFFECT_TECHNIQUE_DESC desc,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sb);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_GetPass")]
      private static extern uint InteropGetPass(
        uint deviceHandle,
        uint handle,
        uint techniqueHandle,
        uint index,
        out UnsafeNativeStructures.EFFECT_PASS_DESC desc,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sb);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_GetParameter")]
      private static extern uint InteropGetParameter(
        uint deviceHandle,
        UnsafeNativeStructures.D3DXPARAM_INPUT input,
        out UnsafeNativeStructures.EFFECT_PARAMETER_DESC desc,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder name,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder semantic);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_GetValue")]
      private static extern unsafe uint InteropGetValue(
        uint deviceHandle,
        uint effectHandle,
        uint paramHandle,
        GetShaderValueType dataType,
        void* pData,
        uint dataSize,
        uint arrayCount);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_GetValueString")]
      private static extern uint InteropGetValueString(
        uint deviceHandle,
        uint effectHandle,
        uint paramHandle,
        [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sb);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_Effect_GetTexture")]
      private static extern uint InteropGetTexture(
        uint deviceHandle,
        uint effectHandle,
        uint paramHandle,
        out uint textureHandle,
        out TextureType textureType,
        out UnsafeNativeStructures.TEXTURE_CREATION_PARAMS parameters);
    }

    public class OcclusionQuery
    {
      private static UnsafeNativeMethods.OcclusionQuery _global;

      private OcclusionQuery()
      {
      }

      public static UnsafeNativeMethods.OcclusionQuery GetGlobal(
        GraphicsDevice dev)
      {
        if (UnsafeNativeMethods.OcclusionQuery._global == null)
          UnsafeNativeMethods.OcclusionQuery._global = new UnsafeNativeMethods.OcclusionQuery();
        dev?.FlushBuffer();
        return UnsafeNativeMethods.OcclusionQuery._global;
      }

      [SecuritySafeCritical]
      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      public void ReleaseHandle(uint deviceHandle, uint handle) => UnsafeNativeMethods.OcclusionQuery.InteropReleaseHandle(deviceHandle, handle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint CreateHandle(uint deviceHandle) => UnsafeNativeMethods.OcclusionQuery.InteropCreateHandle(deviceHandle);

      [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
      [SecuritySafeCritical]
      public uint IsDataAvailable(uint deviceHandle, uint handle, out uint pixelCount) => UnsafeNativeMethods.OcclusionQuery.InteropIsDataAvailable(deviceHandle, handle, out pixelCount);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_OcclusionQuery_ReleaseHandle")]
      private static extern void InteropReleaseHandle(uint deviceHandle, uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_OcclusionQuery_CreateHandle")]
      private static extern uint InteropCreateHandle(uint deviceHandle);

      [DllImport("XnaFrameworkCore", EntryPoint = "D3D_OcclusionQuery_IsDataAvailable")]
      private static extern uint InteropIsDataAvailable(
        uint deviceHandle,
        uint handle,
        out uint pixelCount);
    }

    public class Imaging
    {
      [SecuritySafeCritical]
      public static unsafe uint CreateKernelStream(byte[] buffer)
      {
        uint maxValue = uint.MaxValue;
        fixed (byte* pBuffer = buffer)
          Helpers.ThrowExceptionFromErrorCode((ErrorCodes) UnsafeNativeMethods.Imaging.InteropCreateKernelStream(pBuffer, (uint) buffer.Length, &maxValue));
        return maxValue;
      }

      [SecuritySafeCritical]
      public static void CloseKernelStream(uint handle) => Helpers.ThrowExceptionFromErrorCode((ErrorCodes) UnsafeNativeMethods.Imaging.InteropCloseKernelStream(handle));

      [SecuritySafeCritical]
      public static unsafe uint DecodeStreamToTexture(
        GraphicsDevice device,
        uint streamHandle,
        ref int width,
        ref int height,
        XnaImageOperation operation,
        int maxAspectRatio,
        out uint textureHandle)
      {
        device.FlushBuffer();
        uint num1 = (uint) width;
        uint num2 = (uint) height;
        uint maxValue = uint.MaxValue;
        int texture = (int) UnsafeNativeMethods.Imaging.InteropDecodeStreamToTexture(device.pComPtr, streamHandle, &num1, &num2, operation, maxAspectRatio, &maxValue);
        width = (int) num1;
        height = (int) num2;
        textureHandle = maxValue;
        return (uint) texture;
      }

      [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_CreateKernelMemoryStream")]
      private static extern unsafe uint InteropCreateKernelStream(
        byte* pBuffer,
        uint bufferSize,
        uint* handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_CloseKernelStream")]
      private static extern uint InteropCloseKernelStream(uint handle);

      [DllImport("XnaFrameworkCore", EntryPoint = "Imaging_DecodeStreamToTexture")]
      private static extern unsafe uint InteropDecodeStreamToTexture(
        uint deviceHandle,
        uint streamHandle,
        uint* width,
        uint* height,
        XnaImageOperation operation,
        int maxAspectRatio,
        uint* textureHandle);
    }
  }
}
