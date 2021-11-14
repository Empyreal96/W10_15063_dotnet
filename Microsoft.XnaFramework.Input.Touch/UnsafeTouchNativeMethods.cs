// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.UnsafeTouchNativeMethods
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal static class UnsafeTouchNativeMethods
  {
    [SecuritySafeCritical]
    internal static unsafe void CopyGestureInfo(IntPtr lParam, ref TouchInfoBuffer touchInfo)
    {
      TouchInfoBuffer* touchInfoBufferPtr = (TouchInfoBuffer*) (void*) lParam;
      touchInfo.cbSize = touchInfoBufferPtr->cbSize;
      touchInfo.dwFlags = touchInfoBufferPtr->dwFlags;
      touchInfo.dwTimeStamp = touchInfoBufferPtr->dwTimeStamp;
      touchInfo.hwndTarget = touchInfoBufferPtr->hwndTarget;
      touchInfo.dwSessionID = touchInfoBufferPtr->dwSessionID;
      touchInfo.cContacts = touchInfoBufferPtr->cContacts;
      for (int i = 0; i < (int) touchInfo.cContacts; ++i)
        touchInfo.rgContacts[i] = touchInfoBufferPtr->rgContacts[i];
    }

    [SecuritySafeCritical]
    internal static unsafe uint TouchSessionGetInfoTap(
      IntPtr handle,
      bool doubleTap,
      out GestureTapData data)
    {
      fixed (GestureTapData* gestureTapDataPtr = &data)
        return UnsafeTouchNativeMethods.TouchSessionGetInfo(handle, doubleTap ? GestureDataType.DoubleTap : GestureDataType.Tap, (void*) gestureTapDataPtr);
    }

    [SecuritySafeCritical]
    internal static unsafe uint TouchSessionGetInfoHold(
      IntPtr handle,
      bool shortHold,
      out GestureHoldData data)
    {
      fixed (GestureHoldData* gestureHoldDataPtr = &data)
        return UnsafeTouchNativeMethods.TouchSessionGetInfo(handle, shortHold ? GestureDataType.ShortHold : GestureDataType.Hold, (void*) gestureHoldDataPtr);
    }

    [SecuritySafeCritical]
    internal static unsafe uint TouchSessionGetInfoDrag(IntPtr handle, out GestureDragData data)
    {
      fixed (GestureDragData* gestureDragDataPtr = &data)
        return UnsafeTouchNativeMethods.TouchSessionGetInfo(handle, GestureDataType.Drag, (void*) gestureDragDataPtr);
    }

    [SecuritySafeCritical]
    internal static unsafe uint TouchSessionGetInfoPinchStretch(
      IntPtr handle,
      out GesturePinchStretchData data)
    {
      fixed (GesturePinchStretchData* pinchStretchDataPtr = &data)
        return UnsafeTouchNativeMethods.TouchSessionGetInfo(handle, GestureDataType.PinchStretch, (void*) pinchStretchDataPtr);
    }

    [SecuritySafeCritical]
    internal static unsafe uint TouchSessionGetInfoFlick(IntPtr handle, out GestureFlickData data)
    {
      fixed (GestureFlickData* gestureFlickDataPtr = &data)
        return UnsafeTouchNativeMethods.TouchSessionGetInfo(handle, GestureDataType.Flick, (void*) gestureFlickDataPtr);
    }

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint CreateTouchSession(out IntPtr handle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint TouchSessionAdd(IntPtr handle, ref TouchInfoBuffer touch);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint TouchSessionReadConfigUInt(
      IntPtr handle,
      TouchSessionConfigSetting setting,
      out uint value);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint TouchSessionSetExpected(IntPtr handle, GestureTypeInternal expected);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint TouchSessionQueryPotentials(
      IntPtr handle,
      out GestureTypeInternal potentials);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern unsafe uint TouchSessionGetInfo(
      IntPtr handle,
      GestureDataType type,
      void* data);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint TouchSessionRelease(IntPtr handle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint GamePage_GetClientBounds(
      uint handle,
      ref int left,
      ref int top,
      ref int width,
      ref int height,
      bool fullscreen);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint InitializeInput(bool isUnhosted);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint GetTouchInputEndpoint(out IntPtr touchEndpoint);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint GetTextInputEndpoint(out IntPtr textEndpoint);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint RegisterTouchCallback(
      [MarshalAs(UnmanagedType.FunctionPtr)] ProcessTouchInfoDelegate processTouchInfoDelegate);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint CreateFilterSession(out IntPtr handle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint FilterSessionFilter(IntPtr handle, ref TouchInfoBuffer touch);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint FilterSessionRelease(IntPtr handle);
  }
}
