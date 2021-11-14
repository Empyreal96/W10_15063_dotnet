// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserInteropCallbacks
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

namespace Microsoft.Phone.Controls
{
  internal struct WebBrowserInteropCallbacks
  {
    public NavigatingCallback Navigating;
    public NavigateErrorCallback NavigateError;
    public NavigatedCallback Navigated;
    public LoadCompletedCallback LoadCompleted;
    public ScriptNotifyCallback ScriptNotify;
    public FullScreenChangedCallback FullScreenChanged;
    public GetFrameVerticalOffsetCallback GetFrameVerticalOffset;
    public SIPStateChangeCallback SIPStateChange;
    public CanNavigateBackChangeCallback CanNavigateBackChange;
    public CanNavigateForwardChangeCallback CanNavigateForwardChange;
  }
}
