// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ITask
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

namespace Microsoft.Phone.TaskModel.Interop
{
  internal abstract class ITask
  {
    public ITask.Launching OnLaunching;
    public ITask.BeforePause OnBeforePause;
    public ITask.Pause OnPause;
    public ITask.Resume OnResume;
    public ITask.AfterResume OnAfterResume;
    public ITask.RunningInBackground OnRunningInBackground;
    public ITask.Cancel OnCancel;
    public ITask.Closing OnClosing;
    public ITask.NavigateTo OnNavigateTo;
    public ITask.NavigateAway OnNavigateAway;
    public ITask.Refresh OnRefresh;
    public ITask.Show OnShow;
    public ITask.Hide OnHide;
    public ITask.SystemKeyPressed OnSystemKeyPressed;
    public ITask.StartKeyPressed OnStartKeyPress;
    public ITask.HostDehydrating OnHostDehydrating;
    public ITask.VisibleRegionChanged OnVisibleRegionChange;
    public ITask.MinimizedOverlayVisibleRegionChanged OnMinimizedOverlayVisibleRegionChange;
    public ITask.OrientationChanged OnOrientationChanged;
    public ITask.SipVisibilityChange OnSipVisibilityChange;
    public ITask.NavBarVisibilityChange OnNavBarVisibilityChange;
    public ITask.ObscurityChanged OnObscurityChange;
    public ITask.LockScreenVisibilityChanged OnLockScreenVisibilityChange;
    public ITask.RequestOverlayStateChange OnRequestOverlayStateChange;
    public ITask.ModernActivation OnModernActivation;

    public virtual ITask.ChildTaskReturned OnChildTaskReturned { get; set; }

    public abstract void Detach();

    public abstract void ReadyToNavigate();

    public abstract void Complete(int result);

    public abstract void RequestNavigateBack();

    public abstract void ShowComplete();

    public abstract void FirstPresentComplete();

    public abstract void HideComplete();

    public abstract void LaunchSession(string taskUri, byte[] parameterData);

    public abstract void LaunchChildTask(string taskUri, byte[] parameterData);

    public abstract void LaunchModernChooser(
      string appUri,
      string chooserPackageFamilyName,
      byte[] parameterData);

    public abstract void SetSupportedOrientations(Orientations orientations);

    public abstract Orientations GetSupportedOrientations();

    public abstract Orientations GetCurrentOrientation();

    public delegate void Launching();

    public delegate void BeforePause(uint reason);

    public delegate void Pause(uint reason);

    public delegate void Resume(bool isExecutionContextPreserved);

    public delegate void AfterResume(bool isExecutionContextPreserved);

    public delegate void RunningInBackground();

    public delegate void Cancel();

    public delegate void Closing();

    public delegate void NavigateTo(NavigationDirection direction, bool isResumeActivation);

    public delegate void NavigateAway(NavigationDirection direction);

    public delegate void Refresh();

    public delegate void Show(NavigationDirection direction);

    public delegate void Hide(NavigationDirection direction);

    public delegate void SystemKeyPressed(NavigationSystemKey systemKeyType, out bool pHandled);

    public delegate void StartKeyPressed();

    public delegate void ChildTaskReturned(ChildTaskReturnedEventArgs args);

    public delegate void HostDehydrating();

    public delegate void VisibleRegionChanged();

    public delegate void MinimizedOverlayVisibleRegionChanged();

    public delegate void OrientationChanged(Orientations orientation);

    public delegate void SipVisibilityChange(bool isVisible, int height);

    public delegate void NavBarVisibilityChange(bool isVisible, int height);

    public delegate void ObscurityChanged(bool isObscured);

    public delegate void LockScreenVisibilityChanged(bool isVisible);

    public delegate void RequestOverlayStateChange(uint state);

    public delegate void ModernActivation();
  }
}
