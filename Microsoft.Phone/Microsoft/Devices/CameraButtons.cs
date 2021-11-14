// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.CameraButtons
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using MS.Internal;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace Microsoft.Devices
{
  public static class CameraButtons
  {
    private static ManagedEventCallback _pinnedCallback = new ManagedEventCallback(CameraButtons.RouteKeyEvent);

    [AllowReversePInvokeCalls]
    private static void RouteKeyEvent(CaptureEvent eventId)
    {
      switch (eventId)
      {
        case CaptureEvent.ShutterClick:
          CameraButtons.OnCameraButtonPressed();
          break;
        case CaptureEvent.AutoFocusDown:
          CameraButtons.OnCameraButtonHalfPressed();
          break;
        case CaptureEvent.ShutterOrAfReleased:
          CameraButtons.OnCameraButtonReleased();
          break;
      }
    }

    [SecuritySafeCritical]
    static CameraButtons()
    {
    }

    [SecuritySafeCritical]
    private static void AddRefAcquire()
    {
      CameraNativeMethods.PInvoke_CameraButtons_SetCallback(CameraButtons._pinnedCallback);
      if (QuirksMode.ShouldRequireCameraSessionToGetCameraButtonEvents())
        return;
      CameraNativeMethods.PInvoke_CameraButtons_AddRefAcquire();
    }

    [SecuritySafeCritical]
    private static void ReleaseAcquire()
    {
      if (QuirksMode.ShouldRequireCameraSessionToGetCameraButtonEvents())
        return;
      CameraNativeMethods.PInvoke_CameraButtons_ReleaseAcquire();
    }

    private static void OnCameraButtonPressed()
    {
      EventHandler localCopyShutterPressed = CameraButtons.shutterKeyPressed;
      Deployment.Current.Dispatcher.BeginInvoke((Action) (() =>
      {
        if (localCopyShutterPressed == null)
          return;
        localCopyShutterPressed((object) null, EventArgs.Empty);
      }));
    }

    private static void OnCameraButtonHalfPressed()
    {
      EventHandler localCopyShutterHalfPressed = CameraButtons.shutterKeyHalfPressed;
      Deployment.Current.Dispatcher.BeginInvoke((Action) (() =>
      {
        if (localCopyShutterHalfPressed == null)
          return;
        localCopyShutterHalfPressed((object) null, EventArgs.Empty);
      }));
    }

    private static void OnCameraButtonReleased()
    {
      EventHandler localCopyShutterReleased = CameraButtons.shutterKeyReleased;
      Deployment.Current.Dispatcher.BeginInvoke((Action) (() =>
      {
        if (localCopyShutterReleased == null)
          return;
        localCopyShutterReleased((object) null, EventArgs.Empty);
      }));
    }

    private static event EventHandler shutterKeyPressed;

    private static event EventHandler shutterKeyHalfPressed;

    private static event EventHandler shutterKeyReleased;

    public static event EventHandler ShutterKeyPressed
    {
      add => CameraButtons.AddDelegate(ref CameraButtons.shutterKeyPressed, (Delegate) value);
      remove => CameraButtons.RemoveDelegate(ref CameraButtons.shutterKeyPressed, (Delegate) value);
    }

    public static event EventHandler ShutterKeyHalfPressed
    {
      add => CameraButtons.AddDelegate(ref CameraButtons.shutterKeyHalfPressed, (Delegate) value);
      remove => CameraButtons.RemoveDelegate(ref CameraButtons.shutterKeyHalfPressed, (Delegate) value);
    }

    public static event EventHandler ShutterKeyReleased
    {
      add => CameraButtons.AddDelegate(ref CameraButtons.shutterKeyReleased, (Delegate) value);
      remove => CameraButtons.RemoveDelegate(ref CameraButtons.shutterKeyReleased, (Delegate) value);
    }

    private static void AddDelegate(ref EventHandler existingDelegate, Delegate delegateToAdd)
    {
      Delegate @delegate = Delegate.Combine((Delegate) existingDelegate, delegateToAdd);
      if (existingDelegate == null && (object) @delegate != null)
        CameraButtons.AddRefAcquire();
      existingDelegate = (EventHandler) @delegate;
    }

    private static void RemoveDelegate(ref EventHandler existingDelegate, Delegate delegateToRemove)
    {
      Delegate @delegate = Delegate.Remove((Delegate) existingDelegate, delegateToRemove);
      if (existingDelegate != null && (object) @delegate == null)
        CameraButtons.ReleaseAcquire();
      existingDelegate = (EventHandler) @delegate;
    }
  }
}
