// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.GraphicsHelpers
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class GraphicsHelpers
  {
    public static void ThrowExceptionFromResult(uint result)
    {
      if (result != 0U)
        throw GraphicsHelpers.GetExceptionFromResult(result);
    }

    [SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes")]
    [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
    public static Exception GetExceptionFromResult(uint result)
    {
      switch (result)
      {
        case 0:
          return (Exception) null;
        case 2150814720:
          return (Exception) new InvalidOperationException(FrameworkResources.DirectRenderingWrongMode);
        case 2289435004:
          return (Exception) new OutOfMemoryException();
        case 2289436711:
          return (Exception) new InvalidOperationException(FrameworkResources.DriverError);
        case 2289436776:
          return (Exception) new DeviceLostException();
        case 2289436777:
          return (Exception) new DeviceNotResetException();
        case 2289436784:
          return (Exception) new NotSupportedException();
        default:
          return Helpers.GetExceptionFromResult(result);
      }
    }

    internal static Blend AdjustAlphaBlend(Blend blend)
    {
      switch (blend)
      {
        case Blend.SourceColor:
          return Blend.SourceAlpha;
        case Blend.InverseSourceColor:
          return Blend.InverseSourceAlpha;
        case Blend.DestinationColor:
          return Blend.DestinationAlpha;
        case Blend.InverseDestinationColor:
          return Blend.InverseDestinationAlpha;
        default:
          return blend;
      }
    }

    internal static bool IsSeparateBlend(Blend colorBlend, Blend alphaBlend) => GraphicsHelpers.AdjustAlphaBlend(colorBlend) != GraphicsHelpers.AdjustAlphaBlend(alphaBlend);
  }
}
