// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ProfileCapabilities
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  internal class ProfileCapabilities
  {
    internal GraphicsProfile Profile;
    internal uint VertexShaderVersion;
    internal uint PixelShaderVersion;
    internal bool OcclusionQuery;
    internal bool GetBackBufferData;
    internal bool SeparateAlphaBlend;
    internal bool DestBlendSrcAlphaSat;
    internal bool MinMaxSrcDestBlend;
    internal int MaxPrimitiveCount;
    internal bool IndexElementSize32;
    internal int MaxVertexStreams;
    internal int MaxStreamStride;
    internal int MaxVertexBufferSize;
    internal int MaxIndexBufferSize;
    internal int MaxTextureSize;
    internal int MaxCubeSize;
    internal int MaxVolumeExtent;
    internal int MaxTextureAspectRatio;
    internal int MaxSamplers;
    internal int MaxVertexSamplers;
    internal int MaxRenderTargets;
    internal bool NonPow2Unconditional;
    internal bool NonPow2Cube;
    internal bool NonPow2Volume;
    internal List<SurfaceFormat> ValidTextureFormats = new List<SurfaceFormat>();
    internal List<SurfaceFormat> ValidCubeFormats = new List<SurfaceFormat>();
    internal List<SurfaceFormat> ValidVolumeFormats = new List<SurfaceFormat>();
    internal List<SurfaceFormat> ValidVertexTextureFormats = new List<SurfaceFormat>();
    internal List<SurfaceFormat> InvalidFilterFormats = new List<SurfaceFormat>();
    internal List<SurfaceFormat> InvalidBlendFormats = new List<SurfaceFormat>();
    internal List<DepthFormat> ValidDepthFormats = new List<DepthFormat>();
    internal List<VertexElementFormat> ValidVertexFormats = new List<VertexElementFormat>();
    internal static readonly ProfileCapabilities Reach = new ProfileCapabilities()
    {
      Profile = GraphicsProfile.Reach,
      VertexShaderVersion = 512,
      PixelShaderVersion = 512,
      OcclusionQuery = false,
      GetBackBufferData = false,
      SeparateAlphaBlend = false,
      DestBlendSrcAlphaSat = false,
      MinMaxSrcDestBlend = false,
      MaxPrimitiveCount = (int) ushort.MaxValue,
      IndexElementSize32 = false,
      MaxVertexStreams = 16,
      MaxStreamStride = (int) byte.MaxValue,
      MaxVertexBufferSize = 67108863,
      MaxIndexBufferSize = 67108863,
      MaxTextureSize = 2048,
      MaxCubeSize = 512,
      MaxVolumeExtent = 0,
      MaxTextureAspectRatio = 2048,
      MaxSamplers = 16,
      MaxVertexSamplers = 0,
      MaxRenderTargets = 1,
      NonPow2Unconditional = false,
      NonPow2Cube = false,
      NonPow2Volume = false,
      ValidTextureFormats = {
        SurfaceFormat.Color,
        SurfaceFormat.Bgr565,
        SurfaceFormat.Bgra5551,
        SurfaceFormat.Bgra4444,
        SurfaceFormat.Dxt1,
        SurfaceFormat.Dxt3,
        SurfaceFormat.Dxt5,
        SurfaceFormat.NormalizedByte2,
        SurfaceFormat.NormalizedByte4
      },
      ValidCubeFormats = {
        SurfaceFormat.Color,
        SurfaceFormat.Bgr565,
        SurfaceFormat.Bgra5551,
        SurfaceFormat.Bgra4444,
        SurfaceFormat.Dxt1,
        SurfaceFormat.Dxt3,
        SurfaceFormat.Dxt5
      },
      ValidDepthFormats = {
        DepthFormat.Depth16,
        DepthFormat.Depth24,
        DepthFormat.Depth24Stencil8
      },
      ValidVertexFormats = {
        VertexElementFormat.Color,
        VertexElementFormat.Single,
        VertexElementFormat.Vector2,
        VertexElementFormat.Vector3,
        VertexElementFormat.Vector4,
        VertexElementFormat.Byte4,
        VertexElementFormat.Short2,
        VertexElementFormat.Short4,
        VertexElementFormat.NormalizedShort2,
        VertexElementFormat.NormalizedShort4
      }
    };
    internal static readonly ProfileCapabilities HiDef = new ProfileCapabilities()
    {
      Profile = GraphicsProfile.HiDef,
      VertexShaderVersion = 768,
      PixelShaderVersion = 768,
      OcclusionQuery = true,
      GetBackBufferData = true,
      SeparateAlphaBlend = true,
      DestBlendSrcAlphaSat = true,
      MinMaxSrcDestBlend = false,
      MaxPrimitiveCount = 1048575,
      IndexElementSize32 = true,
      MaxVertexStreams = 16,
      MaxStreamStride = (int) byte.MaxValue,
      MaxVertexBufferSize = 67108863,
      MaxIndexBufferSize = 67108863,
      MaxTextureSize = 4096,
      MaxCubeSize = 4096,
      MaxVolumeExtent = 256,
      MaxTextureAspectRatio = 2048,
      MaxSamplers = 16,
      MaxVertexSamplers = 4,
      MaxRenderTargets = 4,
      NonPow2Unconditional = true,
      NonPow2Cube = true,
      NonPow2Volume = true,
      ValidTextureFormats = {
        SurfaceFormat.Color,
        SurfaceFormat.Bgr565,
        SurfaceFormat.Bgra5551,
        SurfaceFormat.Bgra4444,
        SurfaceFormat.Dxt1,
        SurfaceFormat.Dxt3,
        SurfaceFormat.Dxt5,
        SurfaceFormat.NormalizedByte2,
        SurfaceFormat.NormalizedByte4,
        SurfaceFormat.Rgba1010102,
        SurfaceFormat.Rg32,
        SurfaceFormat.Rgba64,
        SurfaceFormat.Alpha8,
        SurfaceFormat.Single,
        SurfaceFormat.Vector2,
        SurfaceFormat.Vector4,
        SurfaceFormat.HalfSingle,
        SurfaceFormat.HalfVector2,
        SurfaceFormat.HalfVector4,
        SurfaceFormat.HdrBlendable
      },
      ValidCubeFormats = {
        SurfaceFormat.Color,
        SurfaceFormat.Bgr565,
        SurfaceFormat.Bgra5551,
        SurfaceFormat.Bgra4444,
        SurfaceFormat.Dxt1,
        SurfaceFormat.Dxt3,
        SurfaceFormat.Dxt5,
        SurfaceFormat.Rgba1010102,
        SurfaceFormat.Rg32,
        SurfaceFormat.Rgba64,
        SurfaceFormat.Alpha8,
        SurfaceFormat.Single,
        SurfaceFormat.Vector2,
        SurfaceFormat.Vector4,
        SurfaceFormat.HalfSingle,
        SurfaceFormat.HalfVector2,
        SurfaceFormat.HalfVector4,
        SurfaceFormat.HdrBlendable
      },
      ValidVolumeFormats = {
        SurfaceFormat.Color,
        SurfaceFormat.Bgr565,
        SurfaceFormat.Bgra5551,
        SurfaceFormat.Bgra4444,
        SurfaceFormat.Rgba1010102,
        SurfaceFormat.Rg32,
        SurfaceFormat.Rgba64,
        SurfaceFormat.Alpha8,
        SurfaceFormat.Single,
        SurfaceFormat.Vector2,
        SurfaceFormat.Vector4,
        SurfaceFormat.HalfSingle,
        SurfaceFormat.HalfVector2,
        SurfaceFormat.HalfVector4,
        SurfaceFormat.HdrBlendable
      },
      ValidVertexTextureFormats = {
        SurfaceFormat.Single,
        SurfaceFormat.Vector2,
        SurfaceFormat.Vector4,
        SurfaceFormat.HalfSingle,
        SurfaceFormat.HalfVector2,
        SurfaceFormat.HalfVector4,
        SurfaceFormat.HdrBlendable
      },
      InvalidFilterFormats = {
        SurfaceFormat.Single,
        SurfaceFormat.Vector2,
        SurfaceFormat.Vector4,
        SurfaceFormat.HalfSingle,
        SurfaceFormat.HalfVector2,
        SurfaceFormat.HalfVector4,
        SurfaceFormat.HdrBlendable
      },
      InvalidBlendFormats = {
        SurfaceFormat.Single,
        SurfaceFormat.Vector2,
        SurfaceFormat.Vector4,
        SurfaceFormat.HalfSingle,
        SurfaceFormat.HalfVector2,
        SurfaceFormat.HalfVector4
      },
      ValidDepthFormats = {
        DepthFormat.Depth16,
        DepthFormat.Depth24,
        DepthFormat.Depth24Stencil8
      },
      ValidVertexFormats = {
        VertexElementFormat.Color,
        VertexElementFormat.Single,
        VertexElementFormat.Vector2,
        VertexElementFormat.Vector3,
        VertexElementFormat.Vector4,
        VertexElementFormat.Byte4,
        VertexElementFormat.Short2,
        VertexElementFormat.Short4,
        VertexElementFormat.NormalizedShort2,
        VertexElementFormat.NormalizedShort4,
        VertexElementFormat.HalfVector2,
        VertexElementFormat.HalfVector4
      }
    };

    internal static ProfileCapabilities GetInstance(
      GraphicsProfile graphicsProfile)
    {
      if (graphicsProfile == GraphicsProfile.Reach)
        return ProfileCapabilities.Reach;
      if (graphicsProfile == GraphicsProfile.HiDef)
        return ProfileCapabilities.HiDef;
      throw new ArgumentOutOfRangeException(nameof (graphicsProfile));
    }

    internal void ThrowNotSupportedException(string message) => throw new NotSupportedException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, message, (object) this.Profile));

    internal void ThrowNotSupportedException(string message, object arg1) => throw new NotSupportedException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, message, (object) this.Profile, arg1));

    internal void ThrowNotSupportedException(string message, object arg1, object arg2) => throw new NotSupportedException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, message, (object) this.Profile, arg1, arg2));
  }
}
