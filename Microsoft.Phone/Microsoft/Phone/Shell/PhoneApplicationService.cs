// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.PhoneApplicationService
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Navigation;
using Windows.ApplicationModel.Activation;

namespace Microsoft.Phone.Shell
{
  public class PhoneApplicationService : IApplicationService
  {
    private Task task;
    private NativeIdleBehavior idleInterop;
    private object mUserIdleLock = new object();
    private object mApplicationIdleLock = new object();
    private IdleDetectionMode mUserIdleDetection;
    private IdleDetectionMode mApplicationIdleDetection;
    private IDictionary<string, object> _dictionary = (IDictionary<string, object>) new Dictionary<string, object>();
    private StartupMode _startupMode;
    private string _knownTypesKey = ApplicationHost.Current.ProductId + "\\PASKnownTypes";
    private string _pasStateKey = ApplicationHost.Current.ProductId + "\\PASState";
    internal const string PersistedStreamGuid = "a6149f2a-8adc-4ab7-bfe5-f20e3bef1ddf";
    internal const string PersistedKnownTypesGuid = "bac4ce9b-91df-43e6-950b-69b5f9d4d8b6";

    public PhoneApplicationService()
    {
      PhoneApplicationService.Current = PhoneApplicationService.Current == null ? this : throw new InvalidOperationException("Creating multiple instances of PhoneApplicationService is not supported.");
      this.task = ApplicationHost.Current.RootTask;
      Task task1 = this.task;
      task1.OnLaunching = task1.OnLaunching + new ITask.Launching(this.FireLaunching);
      Task task2 = this.task;
      task2.OnPause = task2.OnPause + new ITask.Pause(this.FireDeactivated);
      Task task3 = this.task;
      task3.OnResume = task3.OnResume + new ITask.Resume(this.FireActivated);
      Task task4 = this.task;
      task4.OnClosing = task4.OnClosing + new ITask.Closing(this.FireClosing);
      Task task5 = this.task;
      task5.OnModernActivation = task5.OnModernActivation + new ITask.ModernActivation(this.FireModernContractActivation);
      Task task6 = this.task;
      task6.OnRunningInBackground = task6.OnRunningInBackground + new ITask.RunningInBackground(this.FireRunningInBackground);
      this.idleInterop = new NativeIdleBehavior(this);
      if (new HostInfo().Rehydrated)
        this._startupMode = StartupMode.Activate;
      else
        this._startupMode = StartupMode.Launch;
    }

    public static PhoneApplicationService Current { get; private set; }

    public IdleDetectionMode UserIdleDetectionMode
    {
      get => this.mUserIdleDetection;
      set
      {
        lock (this.mUserIdleLock)
        {
          if (this.mUserIdleDetection == value)
            return;
          this.mUserIdleDetection = value;
          if (value != IdleDetectionMode.Enabled)
          {
            if (value != IdleDetectionMode.Disabled)
              throw new ArgumentException("Not a valid IdleDetection value");
            this.idleInterop.IsUserIdleEnabled = false;
          }
          else
            this.idleInterop.IsUserIdleEnabled = true;
        }
      }
    }

    public IdleDetectionMode ApplicationIdleDetectionMode
    {
      get => this.mApplicationIdleDetection;
      set
      {
        lock (this.mApplicationIdleLock)
        {
          if (this.mApplicationIdleDetection == value)
            return;
          if (value == IdleDetectionMode.Enabled)
            throw new InvalidOperationException("ApplicationIdleDetection cannot be enabled after it has been disabled.");
          if (value != IdleDetectionMode.Disabled)
            throw new ArgumentException("Not a valid IdleDetection value");
          ApplicationHost.Current.RootTask.PauseOnLock = false;
          this.mApplicationIdleDetection = value;
        }
      }
    }

    public IDictionary<string, object> State => this._dictionary;

    public StartupMode StartupMode => this._startupMode;

    public event EventHandler<LaunchingEventArgs> Launching;

    public event EventHandler<ActivatedEventArgs> Activated;

    public event EventHandler<DeactivatedEventArgs> Deactivated;

    public event EventHandler<RunningInBackgroundEventArgs> RunningInBackground;

    public event EventHandler<ClosingEventArgs> Closing;

    [CLSCompliant(false)]
    public event EventHandler<IActivatedEventArgs> ContractActivated;

    public void StartService(ApplicationServiceContext context)
    {
    }

    public void StopService()
    {
    }

    private void SaveState()
    {
      IEnumerable<Type> knownTypes = TypesResolver.GetKnownTypes(this._dictionary);
      byte[] numArray1 = StreamPersister.Serialize(this._dictionary, knownTypes);
      byte[] numArray2 = StreamPersister.Serialize(TypesResolver.GetKnownTypesNames(knownTypes));
      ApplicationHost.Current.RootTask.State[this._pasStateKey] = numArray1;
      ApplicationHost.Current.RootTask.State[this._knownTypesKey] = numArray2;
    }

    private void LoadState()
    {
      byte[] blob = ApplicationHost.Current.RootTask.State[this._knownTypesKey];
      List<string> knownTypeNames = (List<string>) null;
      ref List<string> local = ref knownTypeNames;
      StreamPersister.Deserialize(blob, ref local);
      StreamPersister.Deserialize(ApplicationHost.Current.RootTask.State[this._pasStateKey], TypesResolver.GetKnownTypes(knownTypeNames), ref this._dictionary);
    }

    private LaunchingEventArgs GetLaunchingEventInstance()
    {
      object obj = this.task.UnmarshalTaskInputBuffer(true);
      LaunchingEventArgs launchingEventArgs = (LaunchingEventArgs) null;
      if (obj != null && obj is IActivatedEventArgs iactivatedEventArgs)
      {
        ActivationKind kind = iactivatedEventArgs.Kind;
        switch (kind - 2)
        {
          case 0:
            launchingEventArgs = (LaunchingEventArgs) new ShareLaunchingEventArgs()
            {
              ShareTargetActivatedEventArgs = (iactivatedEventArgs as ShareTargetActivatedEventArgs)
            };
            break;
          case 1:
          case 2:
            break;
          case 3:
            launchingEventArgs = (LaunchingEventArgs) new PhoneFileOpenPickerLaunchingEventArgs()
            {
              FileOpenPickerActivatedEventArgs = (iactivatedEventArgs as FileOpenPickerActivatedEventArgs)
            };
            break;
          case 4:
            launchingEventArgs = (LaunchingEventArgs) new PhoneFileSavePickerLaunchingEventArgs()
            {
              FileSavePickerActivatedEventArgs = (iactivatedEventArgs as FileSavePickerActivatedEventArgs)
            };
            break;
          default:
            if (kind == 13)
            {
              launchingEventArgs = (LaunchingEventArgs) new PhoneAppointmentsProviderLaunchingEventArgs()
              {
                AppointmentsProviderActivatedEventArgs = (iactivatedEventArgs as IAppointmentsProviderActivatedEventArgs)
              };
              break;
            }
            break;
        }
      }
      if (launchingEventArgs == null)
        launchingEventArgs = new LaunchingEventArgs();
      return launchingEventArgs;
    }

    private IActivatedEventArgs GetModernContractActivatedArgs() => this.task.UnmarshalTaskInputBuffer(true) as IActivatedEventArgs;

    private ActivatedEventArgs GetActivatedEventInstance(
      bool isExecutionContextPreserved)
    {
      return new ActivatedEventArgs()
      {
        IsApplicationInstancePreserved = isExecutionContextPreserved
      };
    }

    internal void FireLaunching()
    {
      if (!QuirksMode.ShouldAllowStartupModeLaunchWhenActivated())
        this._startupMode = StartupMode.Launch;
      EventHandler<LaunchingEventArgs> launching = this.Launching;
      if (launching == null)
        return;
      PerfUtil.BeginLogMarker(MarkerEvents.TH_LAUNCHINGEVENT_PAS, "Raising PAS.Launching");
      LaunchingEventArgs launchingEventInstance = this.GetLaunchingEventInstance();
      launching((object) this, launchingEventInstance);
      PerfUtil.EndLogMarker(MarkerEvents.TH_LAUNCHINGEVENT_PAS, "Raised PAS.Launching");
    }

    internal void FireDeactivated(uint reason)
    {
      EventHandler<DeactivatedEventArgs> deactivated = this.Deactivated;
      if (deactivated != null)
      {
        PerfUtil.BeginLogMarker(MarkerEvents.TH_DEACTIVATEDEVENT_PAS, "Raising PAS.Deactivated");
        DeactivationReason reason1;
        try
        {
          reason1 = (DeactivationReason) reason;
        }
        catch
        {
          reason1 = DeactivationReason.UserAction;
        }
        deactivated((object) this, new DeactivatedEventArgs(reason1));
        PerfUtil.EndLogMarker(MarkerEvents.TH_DEACTIVATEDEVENT_PAS, "Raised PAS.Deactivated");
      }
      this.SaveState();
      this._dictionary = (IDictionary<string, object>) null;
    }

    internal void FireActivated(bool isExecutionContextPreserved)
    {
      this.LoadState();
      if (!QuirksMode.ShouldAllowStartupModeLaunchWhenActivated())
        this._startupMode = StartupMode.Activate;
      EventHandler<ActivatedEventArgs> activated = this.Activated;
      if (activated == null)
        return;
      PerfUtil.BeginLogMarker(MarkerEvents.TH_ACTIVATEDEVENT_PAS, "Raising PAS.Activated");
      ActivatedEventArgs activatedEventInstance = this.GetActivatedEventInstance(isExecutionContextPreserved);
      activated((object) this, activatedEventInstance);
      PerfUtil.EndLogMarker(MarkerEvents.TH_ACTIVATEDEVENT_PAS, "Raised PAS.Activated");
    }

    internal void FireModernContractActivation()
    {
      EventHandler<IActivatedEventArgs> contractActivated = this.ContractActivated;
      IActivatedEventArgs contractActivatedArgs = this.GetModernContractActivatedArgs();
      if (contractActivated == null || contractActivatedArgs == null)
        return;
      contractActivated((object) this, contractActivatedArgs);
    }

    internal void FireRunningInBackground()
    {
      EventHandler<RunningInBackgroundEventArgs> runningInBackground = this.RunningInBackground;
      if (runningInBackground != null)
        runningInBackground((object) this, new RunningInBackgroundEventArgs());
      this.SaveState();
    }

    internal void FireClosing()
    {
      EventHandler<ClosingEventArgs> closing = this.Closing;
      if (closing == null)
        return;
      PerfUtil.BeginLogMarker(MarkerEvents.TH_CLOSINGEVENT_PAS, "Raising PAS.Closing");
      closing((object) this, new ClosingEventArgs());
      PerfUtil.EndLogMarker(MarkerEvents.TH_CLOSINGEVENT_PAS, "Raised PAS.Closing");
    }
  }
}
