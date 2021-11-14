// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Helpers
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Phone;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework
{
  internal static class Helpers
  {
    private static object KeepKernelReturnCode = (object) typeof (KernelReturnCode);
    public const uint InvalidHandle = 4294967295;
    public const int MaximumStringLength = 260;
    public const int Guide_MessageBox_MaxButtons = 2;
    public const int MaxNumberOfSignedInPlayers = 1;
    internal const int PlayerAnyIndex = 255;
    public const int MinDisplaySize = 240;

    public static bool Succeeded(int error) => error >= 0;

    public static bool Succeeded(ErrorCodes error) => (int) error >= 0;

    public static bool Failed(int error) => error < 0;

    public static bool Failed(ErrorCodes error) => (int) error < 0;

    [SecuritySafeCritical]
    public static unsafe int SmartGetHashCode(object obj)
    {
      GCHandle gcHandle = GCHandle.Alloc(obj, GCHandleType.Pinned);
      try
      {
        int num1 = Marshal.SizeOf(obj);
        int num2 = 0;
        int num3 = 0;
        int* pointer = (int*) gcHandle.AddrOfPinnedObject().ToPointer();
        while (num2 + 4 <= num1)
        {
          num3 ^= *pointer;
          num2 += 4;
          ++pointer;
        }
        return num3 == 0 ? int.MaxValue : num3;
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public static void ValidateCopyParameters(int dataLength, int dataIndex, int elementCount)
    {
      if (dataIndex < 0 || dataIndex > dataLength)
        throw new ArgumentOutOfRangeException(nameof (dataIndex), FrameworkResources.MustBeValidIndex);
      if (elementCount + dataIndex > dataLength)
        throw new ArgumentOutOfRangeException(nameof (elementCount), FrameworkResources.MustBeValidIndex);
      if (elementCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (elementCount), FrameworkResources.MustBeValidIndex);
    }

    [SecuritySafeCritical]
    public static uint GetSizeOf<T>() where T : struct => (uint) Marshal.SizeOf(typeof (T));

    public static void ThrowExceptionFromErrorCode(ErrorCodes error)
    {
      if (Helpers.Failed(error))
        throw Helpers.GetExceptionFromResult((uint) error);
    }

    public static void ThrowExceptionFromErrorCode(int error)
    {
      if (Helpers.Failed(error))
        throw Helpers.GetExceptionFromResult((uint) error);
    }

    public static void ThrowExceptionFromResult(uint result)
    {
      if (result != 0U)
        throw Helpers.GetExceptionFromResult(result);
    }

    [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    [SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes")]
    [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
    public static Exception GetExceptionFromResult(uint result)
    {
      switch (result)
      {
        case 0:
          return (Exception) null;
        case 2147500033:
          return (Exception) new NotImplementedException();
        case 2147500036:
          throw new InvalidOperationException(FrameworkResources.ResourceInUse);
        case 2147942405:
          return (Exception) new UnauthorizedAccessException();
        case 2147942414:
          throw new OutOfMemoryException();
        case 2147942487:
          return (Exception) new ArgumentException();
        case 2289436696:
          return (Exception) new ArgumentException(FrameworkResources.WrongTextureFormat);
        case 2289436701:
          return (Exception) new InvalidOperationException(FrameworkResources.TooManyOperations);
        case 2289436774:
          return (Exception) new ArgumentException(FrameworkResources.NotFound);
        case 2289436775:
          return (Exception) new ArgumentException(FrameworkResources.MoreData);
        case 2289436786:
          return (Exception) new InvalidOperationException(FrameworkResources.InvalidCall);
        default:
          return (Exception) new InvalidOperationException(FrameworkResources.UnexpectedError);
      }
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    public static void CheckDisposed(object obj, IntPtr pComPtr)
    {
      if (pComPtr == IntPtr.Zero)
        throw new ObjectDisposedException(obj.GetType().Name);
    }

    public static void ValidateOrientation(DisplayOrientation orientation)
    {
      if (orientation != DisplayOrientation.Default && orientation != DisplayOrientation.LandscapeLeft && (orientation != DisplayOrientation.LandscapeRight && orientation != DisplayOrientation.Portrait))
        throw new ArgumentException(FrameworkResources.InvalidDisplayOrientation);
    }

    public static bool IsLandscape(DisplayOrientation orientation) => (uint) (orientation & (DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight)) > 0U;

    public static DisplayOrientation ChooseOrientation(
      DisplayOrientation orientation,
      int width,
      int height,
      bool allowLandscapeLeftAndRight)
    {
      if ((orientation & (DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight | DisplayOrientation.Portrait)) != DisplayOrientation.Default)
        return orientation;
      if (width <= height)
        return DisplayOrientation.Portrait;
      return allowLandscapeLeftAndRight ? DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight : DisplayOrientation.LandscapeLeft;
    }

    public static int MaxDisplayWidth => QuirksMode.ShouldXnaUseMangoDisplaySize() ? 480 : 1280;

    public static int MaxDisplayHeight => QuirksMode.ShouldXnaUseMangoDisplaySize() ? 800 : 1280;

    public static bool ShouldSupportedDisplayModesReturnOnlyCurrentDisplayMode => !QuirksMode.ShouldXnaUseMangoDisplaySize();

    public static bool ShouldCurrentDisplaySizeReturnMangoSize => QuirksMode.ShouldXnaUseMangoDisplaySize();
  }
}
