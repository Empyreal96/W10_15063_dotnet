// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.PacketHelpers
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class PacketHelpers
  {
    private const int PacketHeaderSize = 4;
    private const int ClearPacketSize = 28;
    private const int SetResourceHeaderPacketSize = 4;
    private const int SetStreamSourcePacketSize = 20;
    private const int SetTexturePacketSize = 8;
    private const int EffectPacketHeaderSize = 16;
    private const int EffectApplyHeaderSize = 16;
    private const int EffectSetTextureHeaderSize = 12;
    private const int SetHighFrequencyStatePacketSize = 8;
    private const int SetScissorPacketSize = 20;
    private const int SetViewportPacketSize = 28;
    private const int DrawPrimPacketSize = 16;
    private const int DrawIndexedPrimPacketSize = 28;
    private const int DrawInstancedPrimPacketSize = 32;
    private const int EffectSetTechniquePacketSize = 8;
    private const int DrawUserPrimitivePacketSize = 20;
    private const int DrawUserIndexedPrimitivePacketSize = 28;
    private const int DrawSpritesPacketSize = 16;
    private const int QueryPacketSize = 4;
    public const int Bit1 = 1;
    public const int Bit2 = 2;
    public const int Bit3 = 4;
    public const int Bit4 = 8;
    public const int Bit5 = 16;
    public const int Bit6 = 32;
    public const int Bit7 = 64;
    public const int Bit8 = 128;
    public const int Bit9 = 256;
    public const int Bit10 = 512;
    public const int Bit11 = 1024;
    public const int Bit12 = 2048;
    public const int Bit13 = 4096;
    public const int Bit14 = 8192;
    public const int Bit15 = 16384;
    public const int Bit16 = 32768;
    public const int Bit17 = 65536;
    public const int Bit18 = 131072;
    public const int Bit19 = 262144;
    public const int Bit20 = 524288;
    public const int Bit21 = 1048576;
    public const int Bit22 = 2097152;
    public const int Bit23 = 4194304;
    public const int Bit24 = 8388608;
    public const int Bit25 = 16777216;
    public const int Bit26 = 33554432;
    public const int Bit27 = 67108864;
    public const int Bit28 = 134217728;
    public const int Bit29 = 268435456;
    public const int Bit30 = 536870912;
    public const int Bit31 = 1073741824;
    public const int Bit32 = -2147483648;

    [SecuritySafeCritical]
    public static unsafe void SendQueryPacket(
      GraphicsDevice device,
      OcclusionQuery query,
      HLCBPacketType methodType)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (query != null ? (int) query.pComPtr & 16777215 : 0) | (int) PacketHelpers.MaskPacketType(methodType);
        PacketHelpers.EnsurePacketSize(device, 4U);
        fixed (byte* pData = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          PacketHelpers.WriteObjectIntoPacket((uint) num, pData, device1);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendDrawIndexedPrimitivePacket(
      GraphicsDevice device,
      PrimitiveType type,
      int baseVertex,
      int minVertexIndex,
      int numVertices,
      int startIndex,
      int primitiveCount)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = 0 | (int) PacketHelpers.MaskPacketType(HLCBPacketType.DrawIndexedPrimitives);
        PacketHelpers.EnsurePacketSize(device, 28U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket((uint) type, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(baseVertex, pData3, device);
          byte* pData5 = PacketHelpers.WriteObjectIntoPacket(minVertexIndex, pData4, device);
          byte* pData6 = PacketHelpers.WriteObjectIntoPacket(numVertices, pData5, device);
          byte* pData7 = PacketHelpers.WriteObjectIntoPacket(startIndex, pData6, device);
          PacketHelpers.WriteObjectIntoPacket(primitiveCount, pData7, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendDrawPrimitivePacket(
      GraphicsDevice device,
      PrimitiveType type,
      int start,
      int count)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = 0 | (int) PacketHelpers.MaskPacketType(HLCBPacketType.DrawPrimitives);
        PacketHelpers.EnsurePacketSize(device, 16U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket((uint) type, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(start, pData3, device);
          PacketHelpers.WriteObjectIntoPacket(count, pData4, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendDrawUserIndexedPrimitivePacket(
      GraphicsDevice device,
      PrimitiveType type,
      int numVertices,
      int primitiveCount,
      byte* pVertexData,
      uint dataSize,
      byte* pIndexData,
      uint indexDataSize,
      uint typeSize,
      bool sixteenBit)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num1 = (sixteenBit ? 1 : 0) | (int) PacketHelpers.MaskPacketType(HLCBPacketType.DrawUserIndexedPrimitives);
        uint num2 = (uint) ((ulong) (indexDataSize + 3U) & 18446744073709551612UL);
        PacketHelpers.EnsurePacketSize(device, 28U + dataSize + num2);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num1, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket((uint) type, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(numVertices, pData3, device);
          byte* pData5 = PacketHelpers.WriteObjectIntoPacket(primitiveCount, pData4, device);
          byte* pData6 = PacketHelpers.WriteObjectIntoPacket(dataSize, pData5, device);
          byte* pData7 = PacketHelpers.WriteObjectIntoPacket(indexDataSize, pData6, device);
          byte* numPtr1 = PacketHelpers.WriteObjectIntoPacket(typeSize, pData7, device);
          uint* numPtr2 = (uint*) pVertexData;
          uint* numPtr3 = (uint*) numPtr1;
          for (uint index = dataSize >> 2; index > 0U; --index)
            *numPtr3++ = *numPtr2++;
          device.currentPacketSize += dataSize;
          uint* numPtr4 = (uint*) pIndexData;
          for (uint index = indexDataSize >> 2; index > 0U; --index)
            *numPtr3++ = *numPtr4++;
          if (((int) indexDataSize & 3) != 0)
            *(short*) numPtr3 = (short) *(ushort*) numPtr4;
          device.currentPacketSize += num2;
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendDrawUserPrimitivePacket(
      GraphicsDevice device,
      PrimitiveType type,
      int primitiveCount,
      byte* pVertexData,
      uint dataSize,
      uint typeSize)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (int) PacketHelpers.MaskPacketType(HLCBPacketType.DrawUserPrimitives);
        PacketHelpers.EnsurePacketSize(device, 20U + dataSize);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket((uint) type, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(primitiveCount, pData3, device);
          byte* pData5 = PacketHelpers.WriteObjectIntoPacket(dataSize, pData4, device);
          byte* numPtr1 = PacketHelpers.WriteObjectIntoPacket(typeSize, pData5, device);
          uint* numPtr2 = (uint*) pVertexData;
          uint* numPtr3 = (uint*) numPtr1;
          for (uint index = dataSize >> 2; index > 0U; --index)
            *numPtr3++ = *numPtr2++;
          device.currentPacketSize += dataSize;
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendDrawSpritesPacket(
      GraphicsDevice device,
      int spriteCount,
      void* pSpriteData,
      uint dataSize,
      int textureWidth,
      int textureHeight)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (int) PacketHelpers.MaskPacketType(HLCBPacketType.DrawSprites);
        PacketHelpers.EnsurePacketSize(device, 16U + dataSize);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket(spriteCount, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(textureWidth, pData3, device);
          byte* numPtr1 = PacketHelpers.WriteObjectIntoPacket(textureHeight, pData4, device);
          uint* numPtr2 = (uint*) pSpriteData;
          uint* numPtr3 = (uint*) numPtr1;
          for (uint index = dataSize >> 2; index > 0U; --index)
            *numPtr3++ = *numPtr2++;
          device.currentPacketSize += dataSize;
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendDrawInstancedPrimitivePacket(
      GraphicsDevice device,
      PrimitiveType type,
      int baseVertex,
      int minVertexIndex,
      int numVertices,
      int startIndex,
      int primitiveCount,
      int instanceCount)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (int) PacketHelpers.MaskPacketType(HLCBPacketType.DrawInstancedPrimitives);
        PacketHelpers.EnsurePacketSize(device, 32U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket((uint) type, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(baseVertex, pData3, device);
          byte* pData5 = PacketHelpers.WriteObjectIntoPacket(minVertexIndex, pData4, device);
          byte* pData6 = PacketHelpers.WriteObjectIntoPacket(numVertices, pData5, device);
          byte* pData7 = PacketHelpers.WriteObjectIntoPacket(startIndex, pData6, device);
          byte* pData8 = PacketHelpers.WriteObjectIntoPacket(primitiveCount, pData7, device);
          PacketHelpers.WriteObjectIntoPacket(instanceCount, pData8, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void AddClearPacket(
      GraphicsDevice device,
      ClearOptions options,
      ref Vector4 color,
      float depth,
      int stencil)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (int) (options & (ClearOptions.Target | ClearOptions.DepthBuffer | ClearOptions.Stencil) | (ClearOptions) PacketHelpers.MaskPacketType(HLCBPacketType.Clear));
        PacketHelpers.EnsurePacketSize(device, 28U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket(ref color, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(depth, pData3, device);
          PacketHelpers.WriteObjectIntoPacket(stencil, pData4, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void AddSetStreamSource(
      GraphicsDevice device,
      int stream,
      uint bufferHandle,
      int offsetInBytes,
      int stride,
      int instanceFrequency)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        PacketHelpers.EnsurePacketSize(device, 20U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket(bufferHandle | PacketHelpers.MaskPacketType(HLCBPacketType.SetStreamSource), pData1, device);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket(stream, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(offsetInBytes, pData3, device);
          byte* pData5 = PacketHelpers.WriteObjectIntoPacket(stride, pData4, device);
          PacketHelpers.WriteObjectIntoPacket(instanceFrequency, pData5, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendRenderTargets(
      GraphicsDevice device,
      uint count,
      RenderTargetHelper[] renderTargets,
      RenderTargetBinding[] bindings)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num1 = (int) count | (int) PacketHelpers.MaskPacketType(HLCBPacketType.SetRenderTargets);
        uint num2 = (uint) ((int) count * 4 * 2);
        PacketHelpers.EnsurePacketSize(device, 4U + num2);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num1, pData1, device1);
          for (int index = 0; (long) index < (long) count; ++index)
          {
            byte* pData3 = PacketHelpers.WriteObjectIntoPacket(renderTargets[index].renderTargetHandle, pData2, device);
            pData2 = PacketHelpers.WriteObjectIntoPacket((int) bindings[index]._cubeMapFace, pData3, device);
          }
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendViewPort(GraphicsDevice device, ref Viewport view)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = 0 | (int) PacketHelpers.MaskPacketType(HLCBPacketType.SetViewPort);
        PacketHelpers.EnsurePacketSize(device, 28U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          PacketHelpers.WriteObjectIntoPacket(ref view, pData2, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendScissorRect(GraphicsDevice device, ref Rectangle rect)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = 0 | (int) PacketHelpers.MaskPacketType(HLCBPacketType.SetScissorRect);
        PacketHelpers.EnsurePacketSize(device, 20U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          PacketHelpers.WriteObjectIntoPacket(ref rect, pData2, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendSetHighFrequencyStatePacket(
      GraphicsDevice device,
      HighFrequencyRenderState state,
      uint value)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (int) (state | (HighFrequencyRenderState) PacketHelpers.MaskPacketType(HLCBPacketType.SetHighFrequencyState));
        PacketHelpers.EnsurePacketSize(device, 8U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          PacketHelpers.WriteObjectIntoPacket(value, pData2, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendResourceSetPacket(
      GraphicsDevice device,
      HLCBPacketType packetType,
      uint handle)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (int) handle & 16777215 | (int) PacketHelpers.MaskPacketType(packetType);
        PacketHelpers.EnsurePacketSize(device, 4U);
        fixed (byte* pData = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          PacketHelpers.WriteObjectIntoPacket((uint) num, pData, device1);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendSetTexturePacket(
      GraphicsDevice device,
      HLCBPacketType packetType,
      GraphicsResource resource,
      int index)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (resource != null ? (int) resource.pComPtr & 16777215 : 0) | (int) PacketHelpers.MaskPacketType(packetType);
        PacketHelpers.EnsurePacketSize(device, 8U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          PacketHelpers.WriteObjectIntoPacket(index, pData2, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendEffectSetTechniquePacket(
      GraphicsDevice device,
      Effect effect,
      EffectTechnique technique)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num1 = effect != null ? (int) effect.pComPtr & 16777215 : 0;
        uint num2 = technique != null ? technique._handle & 16777215U : 0U;
        int num3 = (int) PacketHelpers.MaskPacketType(HLCBPacketType.EffectSetTechnique);
        int num4 = num1 | num3;
        PacketHelpers.EnsurePacketSize(device, 8U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num4, pData1, device1);
          PacketHelpers.WriteObjectIntoPacket(num2, pData2, device);
        }
      }
    }

    [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    private static uint GetEffectPacketTypeSize(HLCBPacketType packet)
    {
      uint num = 0;
      switch (packet)
      {
        case HLCBPacketType.EffectSetValueBool:
        case HLCBPacketType.EffectSetValueFloat:
        case HLCBPacketType.EffectSetValueInt:
        case HLCBPacketType.EffectSetValueBoolArray:
        case HLCBPacketType.EffectSetValueFloatArray:
        case HLCBPacketType.EffectSetValueIntArray:
          num = 4U;
          break;
        case HLCBPacketType.EffectSetValueMatrix:
        case HLCBPacketType.EffectSetValueMatrixTranspose:
        case HLCBPacketType.EffectSetValueMatrixArray:
        case HLCBPacketType.EffectSetValueMatrixTransposeArray:
          num = 64U;
          break;
        case HLCBPacketType.EffectSetValueString:
          num = 2U;
          break;
        case HLCBPacketType.EffectSetValueVector:
        case HLCBPacketType.EffectSetValueVectorArray:
          num = 16U;
          break;
      }
      return num;
    }

    [SecuritySafeCritical]
    public static unsafe void SendEffectApplyPacket(
      GraphicsDevice device,
      Effect effect,
      uint index,
      EffectStateFlags stateFlags,
      uint textureFlags)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (effect != null ? (int) effect.pComPtr & 16777215 : 0) | (int) PacketHelpers.MaskPacketType(HLCBPacketType.EffectApply);
        PacketHelpers.EnsurePacketSize(device, 16U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket(index, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket((uint) stateFlags, pData3, device);
          PacketHelpers.WriteObjectIntoPacket(textureFlags, pData4, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendEffectSetTexturePacket(
      GraphicsDevice device,
      uint effectHandle,
      Texture texture,
      uint parameterHandle)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num1 = (int) effectHandle & 16777215;
        uint num2 = texture != null ? texture.pComPtr & 16777215U : 0U;
        int num3 = (int) PacketHelpers.MaskPacketType(HLCBPacketType.EffectSetTexture);
        int num4 = num1 | num3;
        PacketHelpers.EnsurePacketSize(device, 12U);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num4, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket(parameterHandle, pData2, device);
          PacketHelpers.WriteObjectIntoPacket(num2, pData3, device);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendEffectParameterArray(
      GraphicsDevice device,
      HLCBPacketType packet,
      uint effectHandle,
      uint parameterHandle,
      Array data,
      uint multiplier)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num = (int) effectHandle & 16777215 | (int) PacketHelpers.MaskPacketType(packet);
        uint size = PacketHelpers.GetEffectPacketTypeSize(packet) * (uint) data.Length * multiplier;
        PacketHelpers.EnsurePacketSize(device, 16U + size);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket(parameterHandle, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(1, PacketHelpers.WriteObjectIntoPacket((int) ((long) data.Length * (long) multiplier), pData3, device), device);
          PacketHelpers.WriteArrayIntoPacket(data, pData4, device, size);
        }
      }
    }

    [SecuritySafeCritical]
    public static unsafe void SendEffectParameter(
      GraphicsDevice device,
      HLCBPacketType packet,
      uint effectHandle,
      uint parameterHandle,
      void* data,
      uint multiplier)
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        int num1 = (int) effectHandle & 16777215 | (int) PacketHelpers.MaskPacketType(packet);
        uint num2 = PacketHelpers.GetEffectPacketTypeSize(packet) * multiplier;
        PacketHelpers.EnsurePacketSize(device, 16U + num2);
        fixed (byte* pData1 = &device.currentPacket[(int) device.currentPacketSize])
        {
          GraphicsDevice device1 = device;
          byte* pData2 = PacketHelpers.WriteObjectIntoPacket((uint) num1, pData1, device1);
          byte* pData3 = PacketHelpers.WriteObjectIntoPacket(parameterHandle, pData2, device);
          byte* pData4 = PacketHelpers.WriteObjectIntoPacket(multiplier, pData3, device);
          byte* numPtr1 = PacketHelpers.WriteObjectIntoPacket(multiplier == 1U ? 0 : 1, pData4, device);
          uint* numPtr2 = (uint*) data;
          uint* numPtr3 = (uint*) numPtr1;
          for (uint index = num2; index > 0U; index -= 4U)
            *numPtr3++ = *numPtr2++;
          device.currentPacketSize += num2;
        }
      }
    }

    private static void EnsurePacketSize(GraphicsDevice device, uint size)
    {
      if (device.currentPacketSize + size <= 32768U)
        return;
      device.FlushBuffer();
      if (size > 32768U)
        throw new InvalidOperationException(FrameworkResources.NotEnoughPacketSpace);
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(uint obj, byte* pData, GraphicsDevice device)
    {
      *(int*) pData = (int) obj;
      device.currentPacketSize += 4U;
      return pData + 4;
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(int obj, byte* pData, GraphicsDevice device)
    {
      *(int*) pData = obj;
      device.currentPacketSize += 4U;
      return pData + 4;
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(
      float obj,
      byte* pData,
      GraphicsDevice device)
    {
      *(float*) pData = obj;
      device.currentPacketSize += 4U;
      return pData + 4;
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(
      ref Matrix obj,
      byte* pData,
      GraphicsDevice device)
    {
      *(Matrix*) pData = obj;
      device.currentPacketSize += (uint) sizeof (Matrix);
      return pData + sizeof (Matrix);
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(
      ref Vector4 obj,
      byte* pData,
      GraphicsDevice device)
    {
      *(Vector4*) pData = obj;
      device.currentPacketSize += (uint) sizeof (Vector4);
      return pData + sizeof (Vector4);
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(
      ref Plane obj,
      byte* pData,
      GraphicsDevice device)
    {
      *(Plane*) pData = obj;
      device.currentPacketSize += (uint) sizeof (Plane);
      return pData + sizeof (Plane);
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(
      ref Rectangle obj,
      byte* pData,
      GraphicsDevice device)
    {
      *(Rectangle*) pData = obj;
      device.currentPacketSize += (uint) sizeof (Rectangle);
      return pData + sizeof (Rectangle);
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteObjectIntoPacket(
      ref Viewport obj,
      byte* pData,
      GraphicsDevice device)
    {
      *(Viewport*) pData = obj;
      device.currentPacketSize += (uint) sizeof (Viewport);
      return pData + sizeof (Viewport);
    }

    [SecuritySafeCritical]
    private static unsafe byte* WriteArrayIntoPacket(
      Array obj,
      byte* pData,
      GraphicsDevice device,
      uint size)
    {
      GCHandle gcHandle = GCHandle.Alloc((object) obj, GCHandleType.Pinned);
      try
      {
        Marshal.Copy(gcHandle.AddrOfPinnedObject(), device.currentPacket, (int) device.currentPacketSize, (int) size);
        device.currentPacketSize += size;
        return pData + size;
      }
      finally
      {
        gcHandle.Free();
      }
    }

    internal static uint MaskPacketType(HLCBPacketType packetType) => (uint) packetType << 24;
  }
}
