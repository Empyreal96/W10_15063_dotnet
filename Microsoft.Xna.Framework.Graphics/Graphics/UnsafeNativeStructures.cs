// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.UnsafeNativeStructures
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class UnsafeNativeStructures
  {
    internal struct D3D_RENDERTARGET_CREATION_PARAMS
    {
      internal uint _width;
      internal uint _height;
      internal uint _numberLevels;
      internal SurfaceFormat _format;
      internal DepthFormat _depthFormat;
      internal uint _msType;
      internal uint _preserve;

      public static UnsafeNativeStructures.D3D_RENDERTARGET_CREATION_PARAMS GetStructure(
        int w,
        int h,
        bool mip,
        SurfaceFormat fmt,
        DepthFormat depthFmt,
        int mt,
        RenderTargetUsage usage)
      {
        return new UnsafeNativeStructures.D3D_RENDERTARGET_CREATION_PARAMS()
        {
          _width = (uint) w,
          _height = (uint) h,
          _numberLevels = mip ? 0U : 1U,
          _format = fmt,
          _depthFormat = depthFmt,
          _msType = (uint) mt,
          _preserve = usage == RenderTargetUsage.PreserveContents ? 1U : 0U
        };
      }
    }

    internal struct D3DXPARAM_INPUT
    {
      internal uint _handle;
      internal uint _parentHandle;
      internal uint _index;
      internal D3DXEffectParameterType _type;

      public static UnsafeNativeStructures.D3DXPARAM_INPUT GetStructure(
        uint h,
        uint p,
        uint i,
        D3DXEffectParameterType type)
      {
        return new UnsafeNativeStructures.D3DXPARAM_INPUT()
        {
          _handle = h,
          _parentHandle = p,
          _index = i,
          _type = type
        };
      }
    }

    internal struct DUIP_PARAMS
    {
      internal uint MinIndex;
      internal uint NumVertices;
      internal uint PrimitiveCount;
      internal unsafe void* pIndexData;
      internal uint IndexDataSize;
      internal unsafe void* pVertexData;
      internal uint VertexDataSize;
      internal uint VertexStride;
      internal uint IsSixteenBit;

      [SecuritySafeCritical]
      public static unsafe UnsafeNativeStructures.DUIP_PARAMS GetParams(
        int min,
        int num,
        int count,
        void* pVertex,
        uint vertexSize,
        void* pIndex,
        uint indexSize,
        uint stride,
        bool sixteen)
      {
        return new UnsafeNativeStructures.DUIP_PARAMS()
        {
          MinIndex = (uint) min,
          NumVertices = (uint) num,
          PrimitiveCount = (uint) count,
          pVertexData = pVertex,
          pIndexData = pIndex,
          VertexStride = stride,
          IsSixteenBit = sixteen ? uint.MaxValue : 0U,
          IndexDataSize = indexSize,
          VertexDataSize = vertexSize
        };
      }
    }

    internal struct EFFECT_DESC
    {
      public uint Parameters;
      public uint Techniques;
    }

    internal struct EFFECT_TECHNIQUE_DESC
    {
      public uint Passes;
      public uint Annotations;
    }

    internal struct EFFECT_PASS_DESC
    {
      public uint Annotations;
      public uint vs;
      public uint ps;
    }

    internal struct EFFECT_PARAMETER_DESC
    {
      public EffectParameterClass Class;
      public EffectParameterType Type;
      public uint Rows;
      public uint Columns;
      public uint Elements;
      public uint Annotations;
      public uint StructMembers;
    }

    internal struct VERTEX_COPYDATA_INFO
    {
      public uint dwVertexStride;
      public uint dwElementCount;
      public uint dwElementSize;
      public uint dwOptions;

      public VERTEX_COPYDATA_INFO(uint stride, uint count, uint size, uint options)
      {
        this.dwVertexStride = stride;
        this.dwElementSize = size;
        this.dwElementCount = count;
        this.dwOptions = options;
      }
    }

    internal struct TEXTURE3D_COPYDATA_INFO
    {
      public unsafe void* pData;
      public uint dwLevel;
      public uint dwDataSize;
      public uint dwElementSize;
      public uint dwElementCount;
      public uint uiLeft;
      public uint uiTop;
      public uint uiRight;
      public uint uiBottom;
      public uint uiFront;
      public uint uiBack;

      [SecuritySafeCritical]
      public unsafe TEXTURE3D_COPYDATA_INFO(
        void* pBuffer,
        int level,
        uint elementSize,
        uint count,
        int l,
        int t,
        int r,
        int b,
        int f,
        int back)
      {
        this.pData = pBuffer;
        this.dwLevel = (uint) level;
        this.dwElementSize = elementSize;
        this.dwElementCount = count;
        this.dwDataSize = this.dwElementSize * this.dwElementCount;
        this.uiLeft = (uint) l;
        this.uiTop = (uint) t;
        this.uiRight = (uint) r;
        this.uiBottom = (uint) b;
        this.uiFront = (uint) f;
        this.uiBack = (uint) back;
      }
    }

    internal struct TEXTURE_COPYDATA_INFO
    {
      public uint dwLevel;
      public uint dwDataSize;
      public uint dwElementSize;
      public uint dwElementCount;

      public TEXTURE_COPYDATA_INFO(uint level, uint elementSize, uint count)
      {
        this.dwLevel = level;
        this.dwElementSize = elementSize;
        this.dwElementCount = count;
        this.dwDataSize = this.dwElementSize * this.dwElementCount;
      }
    }

    internal struct TEXTURECUBE_COPYDATA_INFO
    {
      public uint dwLevel;
      public uint dwDataSize;
      public CubeMapFace _face;
      public uint dwElementSize;
      public uint dwElementCount;

      public TEXTURECUBE_COPYDATA_INFO(uint level, CubeMapFace face, uint elementSize, uint count)
      {
        this.dwLevel = level;
        this._face = face;
        this.dwElementSize = elementSize;
        this.dwElementCount = count;
        this.dwDataSize = this.dwElementSize * this.dwElementCount;
      }
    }

    internal struct TEXTURE_CREATION_PARAMS
    {
      public uint dwWidth;
      public uint dwHeight;
      public uint dwDepth;
      public uint dwLevels;
      public SurfaceFormat dwFormat;
      public int isVideo;

      public TEXTURE_CREATION_PARAMS(
        uint width,
        uint height,
        uint depth,
        bool mip,
        SurfaceFormat format,
        int video)
      {
        this.dwWidth = width;
        this.dwHeight = height;
        this.dwDepth = depth;
        this.dwLevels = mip ? 0U : 1U;
        this.dwFormat = format;
        this.isVideo = video;
      }
    }

    internal struct DISPLAY_MODE_INFO
    {
      public int Width;
      public int Height;
      public SurfaceFormat Format;
    }

    internal struct QUERY_FORMAT_INFO
    {
      public SurfaceFormat Format;
      public DepthFormat DepthFormat;
      public int MultiSampleCount;
    }

    internal struct VERTEX_ELEMENT
    {
      public int Stream;
      public int Offset;
      public VertexElementFormat Format;
      public VertexElementUsage Usage;
      public int UsageIndex;
    }

    internal struct ADAPTER_DESC
    {
      public int VendorId;
      public int DeviceId;
      public int SubSystemId;
      public int Revision;
    }
  }
}
