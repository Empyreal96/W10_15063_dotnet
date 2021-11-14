// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.VertexElementValidator
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class VertexElementValidator
  {
    internal static int GetVertexStride(VertexElement[] elements)
    {
      int num1 = 0;
      for (int index = 0; index < elements.Length; ++index)
      {
        int num2 = elements[index].Offset + VertexElementValidator.GetTypeSize(elements[index].VertexElementFormat);
        if (num1 < num2)
          num1 = num2;
      }
      return num1;
    }

    internal static void Validate(int vertexStride, VertexElement[] elements)
    {
      if (vertexStride <= 0)
        throw new ArgumentOutOfRangeException(nameof (vertexStride));
      int[] numArray = (vertexStride & 3) == 0 ? new int[vertexStride] : throw new ArgumentException(FrameworkResources.VertexElementOffsetNotMultipleFour);
      for (int index = 0; index < vertexStride; ++index)
        numArray[index] = -1;
      for (int index1 = 0; index1 < elements.Length; ++index1)
      {
        int offset = elements[index1].Offset;
        int typeSize = VertexElementValidator.GetTypeSize(elements[index1].VertexElementFormat);
        if (elements[index1].VertexElementUsage < VertexElementUsage.Position || elements[index1].VertexElementUsage > VertexElementUsage.TessellateFactor)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexElementBadUsage, (object) elements[index1].VertexElementUsage, (object) string.Empty));
        if (offset < 0 || offset + typeSize > vertexStride)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexElementOutsideStride, (object) elements[index1].VertexElementUsage, (object) elements[index1].UsageIndex));
        if ((offset & 3) != 0)
          throw new ArgumentException(FrameworkResources.VertexElementOffsetNotMultipleFour);
        for (int index2 = 0; index2 < index1; ++index2)
        {
          if (elements[index1].VertexElementUsage == elements[index2].VertexElementUsage && elements[index1].UsageIndex == elements[index2].UsageIndex)
            throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.DuplicateVertexElement, (object) elements[index1].VertexElementUsage, (object) elements[index1].UsageIndex));
        }
        for (int index2 = offset; index2 < offset + typeSize; ++index2)
        {
          if (numArray[index2] >= 0)
            throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexElementsOverlap, (object) elements[numArray[index2]].VertexElementUsage, (object) elements[numArray[index2]].UsageIndex, (object) elements[index1].VertexElementUsage, (object) elements[index1].UsageIndex));
          numArray[index2] = index1;
        }
      }
    }

    internal static void Validate(
      int vertexStride,
      VertexElement[] elements,
      ProfileCapabilities profile)
    {
      VertexElementValidator.Validate(vertexStride, elements);
      if (vertexStride > profile.MaxStreamStride)
        profile.ThrowNotSupportedException(FrameworkResources.ProfileMaxVertexStride, (object) profile.MaxStreamStride);
      if (elements.Length > profile.MaxVertexStreams)
        profile.ThrowNotSupportedException(FrameworkResources.ProfileMaxVertexElements, (object) profile.MaxVertexStreams);
      for (int index = 0; index < elements.Length; ++index)
      {
        if (!profile.ValidVertexFormats.Contains(elements[index].VertexElementFormat))
          profile.ThrowNotSupportedException(FrameworkResources.ProfileFormatNotSupported, (object) typeof (VertexElement).Name, (object) elements[index].VertexElementFormat);
        if (elements[index].UsageIndex < 0 || elements[index].UsageIndex >= profile.MaxVertexStreams)
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexElementBadUsage, (object) elements[index].VertexElementUsage, (object) elements[index].UsageIndex));
      }
    }

    internal static int GetTypeSize(VertexElementFormat format)
    {
      switch (format)
      {
        case VertexElementFormat.Single:
          return 4;
        case VertexElementFormat.Vector2:
          return 8;
        case VertexElementFormat.Vector3:
          return 12;
        case VertexElementFormat.Vector4:
          return 16;
        case VertexElementFormat.Color:
          return 4;
        case VertexElementFormat.Byte4:
          return 4;
        case VertexElementFormat.Short2:
          return 4;
        case VertexElementFormat.Short4:
          return 8;
        case VertexElementFormat.NormalizedShort2:
          return 4;
        case VertexElementFormat.NormalizedShort4:
          return 8;
        case VertexElementFormat.HalfVector2:
          return 4;
        case VertexElementFormat.HalfVector4:
          return 8;
        default:
          return 0;
      }
    }
  }
}
