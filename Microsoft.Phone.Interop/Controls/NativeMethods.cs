// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.NativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Controls
{
  internal static class NativeMethods
  {
    private const string WebBrowserControlDll = "AgWebBrowserControl.dll";

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int GetWebBrowser(
      int iTileHostId,
      out int defaultDocumentBackgroundColorXRGB,
      out IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int GetWebBrowserUiaProvider(
      IntPtr adapter,
      IntPtr windowlessSite,
      ref IntPtr provider);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int NavigateCustom(
      IntPtr adapter,
      [MarshalAs(UnmanagedType.LPWStr), In] string pszUri,
      int cPostData,
      [MarshalAs(UnmanagedType.LPArray), In] byte[] postData,
      [MarshalAs(UnmanagedType.LPWStr), In] string pszHeaders);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern bool ShortHold(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void LoseFocus(IntPtr adapter, bool hideSIP);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern bool ManipulationDelta(
      IntPtr adapter,
      double xManipOriginAtUOZ,
      double yManipOriginAtUOZ,
      double xCummulativeTranslationAtSOZ,
      double yCummulativeTranslationAtSOZ,
      double xDeltaTranslationAtSOZ,
      double yDeltaTranslationAtSOZ,
      float currentZoom);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern bool ManipulationCompleted(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern bool PinchStretch(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int NavigateToString(IntPtr adapter, [MarshalAs(UnmanagedType.LPWStr), In] string pszHtml);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void NavigateBack(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void NavigateForward(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int SaveToString(IntPtr adapter, [MarshalAs((UnmanagedType) 19)] out string pbstrDocumentText);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int InvokeScript(
      IntPtr adapter,
      [MarshalAs(UnmanagedType.LPWStr)] string scriptName,
      int argc,
      [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] args,
      [MarshalAs((UnmanagedType) 19)] out string result);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int SetInteropCallbacks(
      IntPtr adapter,
      NativeMethods.NavigatingCallback navigating,
      NativeMethods.NavigateErrorCallback navigateError,
      NativeMethods.NavigatedCallback navigated,
      NativeMethods.LoadCompletedCallback loaded,
      NativeMethods.ScriptNotifyCallback scriptNotify,
      NativeMethods.FullScreenChangedCallback fullScreenChanged,
      NativeMethods.DocumentSizeChangeCallback documentSizeChange,
      NativeMethods.BeginDocumentSwitchCallback beginDocumentSwitch,
      NativeMethods.EndDocumentSwitchCallback endDocumentSwitch,
      NativeMethods.ZoomAndScrollCallback zoomAndScroll,
      NativeMethods.ZoomConstraintsChangeCallback zoomConstraintsChange,
      NativeMethods.TransformRectUOZtoScreenCallback transformRectUOZtoScreen,
      NativeMethods.TransformPointUOZtoScreenCallback transformPointUOZtoScreen,
      NativeMethods.SIPStateChangeCallback SIPStateChange,
      NativeMethods.PulseCallback pulse,
      NativeMethods.CanNavigateBackChangeCallback canNavigateBackChange,
      NativeMethods.CanNavigateForwardChangeCallback canNavigateForwardChange);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void InteropAbandoned(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int GetSource(IntPtr adapter, [MarshalAs(UnmanagedType.LPWStr)] out string pszUri);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void SetIsScriptEnabled(IntPtr adapter, [MarshalAs(UnmanagedType.U1), In] bool bEnabled);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void SetIsGeolocationEnabled(IntPtr adapter, [MarshalAs(UnmanagedType.U1), In] bool bEnabled);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int GetBase(IntPtr adapter, [MarshalAs(UnmanagedType.LPWStr)] out string pszRelativeBase);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern int SetBase(IntPtr adapter, [MarshalAs(UnmanagedType.LPWStr)] string relativeBase);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void UpdateZoomerIdle(
      IntPtr adapter,
      double left,
      double top,
      double width,
      double height,
      float opticalZoomMultiplier);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void UpdateZoomerActive(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void DoPendingEditActivation(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void UpdateOrientation(IntPtr adapter, [MarshalAs(UnmanagedType.I4), In] int rotationAngle);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void Copy(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void Paste(IntPtr adapter);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void SetBackgroundColor(IntPtr adapter, [MarshalAs(UnmanagedType.U4), In] int color);

    [DllImport("AgWebBrowserControl.dll")]
    public static extern void SetExternalInputIdAndContentScaleFactor(
      IntPtr adapter,
      int iExternalInputId,
      float factor);

    public static void ValidateHResult(int hr)
    {
      if (hr >= 0)
        return;
      if (hr == -2147024882)
        throw new OutOfMemoryException();
      if (hr == -2147024726)
        throw WebBrowserExceptionHelper.GetBusyException();
      if (hr == -2144731133)
        throw WebBrowserExceptionHelper.GetIllegalReentrancyException();
      throw WebBrowserExceptionHelper.GetUnknownHResultException(hr);
    }

    public delegate void NavigatingCallback(int webBrowserControlId, [MarshalAs(UnmanagedType.LPWStr)] string uri, [MarshalAs(UnmanagedType.Bool)] out bool cancel);

    public delegate void NavigateErrorCallback(
      int webBrowserControlId,
      [MarshalAs(UnmanagedType.LPWStr)] string uri,
      int statusCode,
      [MarshalAs(UnmanagedType.Bool)] out bool cancel);

    public delegate void NavigatedCallback(int webBrowserControlId, [MarshalAs(UnmanagedType.LPWStr)] string uri);

    public delegate void LoadCompletedCallback(
      int webBrowserControlId,
      [MarshalAs(UnmanagedType.LPWStr)] string uri,
      int backgroundColorXRGB);

    public delegate void ScriptNotifyCallback(int webBrowserControlId, [MarshalAs(UnmanagedType.LPWStr)] string value);

    public delegate void FullScreenChangedCallback(int webBrowserControlId, [MarshalAs(UnmanagedType.Bool)] bool isFullScreen);

    public delegate void DocumentSizeChangeCallback(
      int webBrowserControlId,
      int width,
      int height,
      float minimumZoom,
      float maximumZoom,
      bool isRTL);

    public delegate void BeginDocumentSwitchCallback(
      int webBrowserControlId,
      float minimumZoom,
      float maximumZoom,
      float zoom,
      int widthAtUOZ,
      int heightAtUOZ,
      int backgroundColorXRGB);

    public delegate void EndDocumentSwitchCallback(
      int webBrowserControlId,
      float minimumZoom,
      float maximumZoom,
      float zoom,
      int widthAtUOZ,
      int heightAtUOZ);

    public delegate void ZoomAndScrollCallback(
      int webBrowserControlId,
      int x,
      int y,
      float zoom,
      bool animate);

    public delegate void ZoomConstraintsChangeCallback(
      int webBrowserControlId,
      float minimumZoom,
      float maximumZoom,
      float initialZoom,
      bool isViewportWidthOrientationDependent);

    public delegate void SIPStateChangeCallback(int webBrowserControlId, bool visible);

    public delegate void PulseCallback(int webBrowserControlId);

    public delegate void CanNavigateBackChangeCallback(int webBrowserControlId, bool enabled);

    public delegate void CanNavigateForwardChangeCallback(int webBrowserControlId, bool enabled);

    public delegate void TransformRectUOZtoScreenCallback(
      int webBrowserControlId,
      int iInLeft,
      int iInTop,
      int iInRight,
      int iInBottom,
      out double dOutLeft,
      out double dOutTop,
      out double dOutRight,
      out double dOutBottom);

    public delegate void TransformPointUOZtoScreenCallback(
      int webBrowserControlId,
      int iInX,
      int iInY,
      out double dOutX,
      out double dOutY);
  }
}
