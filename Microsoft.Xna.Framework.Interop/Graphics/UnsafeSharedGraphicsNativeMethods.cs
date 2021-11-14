// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.UnsafeSharedGraphicsNativeMethods
// Assembly: Microsoft.Xna.Framework.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: E258DF81-FBD7-4DF4-930E-981F36DBB495
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI20E9~1.DLL

using MS.Internal;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class UnsafeSharedGraphicsNativeMethods
  {
    [SecuritySafeCritical]
    internal static uint CreatePageHandle(int windowHandle) => UnsafeSharedGraphicsNativeMethods.InteropCreatePageHandle(windowHandle);

    [SecuritySafeCritical]
    internal static void GamePage_ReleaseHandle(uint handle) => UnsafeSharedGraphicsNativeMethods.InteropGamePage_ReleaseHandle(handle);

    [SecuritySafeCritical]
    internal static int GamePage_GetWindowHandle(uint handle) => UnsafeSharedGraphicsNativeMethods.InteropGamePage_GetWindowHandle(handle);

    [SecuritySafeCritical]
    internal static uint GamePage_GetClientBounds(
      uint handle,
      ref int left,
      ref int top,
      ref int width,
      ref int height,
      bool fullscreen)
    {
      return UnsafeSharedGraphicsNativeMethods.InteropGamePage_GetClientBounds(handle, ref left, ref top, ref width, ref height, fullscreen);
    }

    [SecuritySafeCritical]
    internal static void GamePage_SetClientBounds(
      uint handle,
      int left,
      int top,
      int width,
      int height)
    {
      UnsafeSharedGraphicsNativeMethods.InteropGamePage_SetClientBounds(handle, left, top, width, height);
    }

    [SecurityCritical]
    public static uint DirectRendering_Initialize(
      uint adapterHandle,
      IntPtr coreServicesContext,
      IntPtr sharedGraphicsDevice,
      IntPtr sharedGraphicsDeviceContext,
      IntPtr sharedDCompDevice)
    {
      XcpImports.CheckThread();
      return UnsafeSharedGraphicsNativeMethods.InteropDirectRendering_Initialize(adapterHandle, coreServicesContext, sharedGraphicsDevice, sharedGraphicsDeviceContext, sharedDCompDevice);
    }

    [SecuritySafeCritical]
    public static uint DirectRendering_Uninitialize() => UnsafeSharedGraphicsNativeMethods.InteropDirectRendering_Uninitialize();

    [SecurityCritical]
    public static uint DirectRendering_Begin(uint handle) => UnsafeSharedGraphicsNativeMethods.InteropDirectRendering_Begin(handle);

    [SecurityCritical]
    public static uint DirectRendering_End(uint handle) => UnsafeSharedGraphicsNativeMethods.InteropDirectRendering_End(handle);

    [SecurityCritical]
    public static uint DirectRendering_RenderSharedTexture(
      uint deviceHandle,
      DependencyObject drt,
      uint width,
      uint height,
      ref uint textureHandle)
    {
      return UnsafeSharedGraphicsNativeMethods.InteropDirectRendering_RenderSharedTexture(deviceHandle, drt.NativeObject, width, height, ref textureHandle);
    }

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "CreatePageHandle")]
    internal static extern uint InteropCreatePageHandle(int windowHandle);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "GamePage_ReleaseHandle")]
    internal static extern void InteropGamePage_ReleaseHandle(uint handle);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "GamePage_GetWindowHandle")]
    internal static extern int InteropGamePage_GetWindowHandle(uint handle);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "GamePage_GetClientBounds")]
    internal static extern uint InteropGamePage_GetClientBounds(
      uint handle,
      ref int left,
      ref int top,
      ref int width,
      ref int height,
      bool fullscreen);

    [DllImport("XnaFrameworkCore.dll", EntryPoint = "GamePage_SetClientBounds")]
    internal static extern void InteropGamePage_SetClientBounds(
      uint handle,
      int left,
      int top,
      int width,
      int height);

    [DllImport("XnaFrameworkCore", EntryPoint = "DirectRendering_Initialize")]
    internal static extern uint InteropDirectRendering_Initialize(
      uint adapterHandle,
      IntPtr coreServicesContext,
      IntPtr sharedGraphicsDevice,
      IntPtr sharedGraphicsDeviceContext,
      IntPtr sharedDCompDevice);

    [DllImport("XnaFrameworkCore", EntryPoint = "DirectRendering_Uninitialize")]
    internal static extern uint InteropDirectRendering_Uninitialize();

    [DllImport("XnaFrameworkCore", EntryPoint = "DirectRendering_Begin")]
    internal static extern uint InteropDirectRendering_Begin(uint deviceHandle);

    [DllImport("XnaFrameworkCore", EntryPoint = "DirectRendering_End")]
    internal static extern uint InteropDirectRendering_End(uint deviceHandle);

    [DllImport("XnaFrameworkCore", EntryPoint = "DirectRendering_RenderSharedTexture")]
    internal static extern uint InteropDirectRendering_RenderSharedTexture(
      uint deviceHandle,
      IntPtr drt,
      uint width,
      uint height,
      ref uint textureHandle);
  }
}
