// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.TaskCallbacks
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecuritySafeCritical]
  [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable", Justification = "These are just function pointers.")]
  internal struct TaskCallbacks
  {
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnLaunching;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnPause;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnResume;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnRunningInBackground;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnCancel;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnClosing;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnNavigateTo;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnNavigateAway;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnRefresh;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnShow;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnHide;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnSystemKeyPressed;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnChildTaskReturned;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnHostDehydrating;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnVisibleRegionChange;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnOrientationChanged;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnSipVisibilityChange;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnNavBarVisibilityChange;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnObscurityChange;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnLockScreenVisibilityChange;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnApplicationLayerChange;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnRequestOverlayStateChange;
    [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Justification = "This is a function pointer that must outlive the call that passes them to native.")]
    public IntPtr pfnOnModernActivation;
  }
}
