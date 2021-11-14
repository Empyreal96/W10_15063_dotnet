// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.Camera
// Assembly: Microsoft.Devices.Camera, Version=0.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: EF9A4555-242B-4723-B191-4FF24D598391
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI27EF~1.DLL

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Windows.Foundation;
using Windows.Phone.Media.Capture;

namespace Microsoft.Devices
{
  public abstract class Camera : IDisposable
  {
    internal static Guid videoPortNamePropertyGuid = new Guid("17e10083-5482-4e5c-b459-85da947826d2");
    private object _lock = new object();
    private System.Windows.Size? _currentResolution;
    private bool _isDisposed;
    private bool _initializeAttempted;
    private ReadOnlyCollection<System.Windows.Size> _resolutions;
    private ReadOnlyCollection<System.Windows.Size> _previewResolutions;
    private Camera.LegacyAPIManagedEventCallback _pinnedCallback;
    protected volatile PhotoCaptureDevice _photoCaptureDevice;
    protected CameraCaptureSequence _captureSequence;
    protected AutoResetEvent _previewFrameEvent;

    [DllImport("CaptureServiceClient.dll", PreserveSig = false)]
    private static extern void PInvoke_LegacyAPIHelper_WaitInit(
      Camera.LegacyAPIManagedEventCallback cb);

    [DllImport("CaptureServiceClient.dll", PreserveSig = false)]
    private static extern void PInvoke_LegacyAPIHelper_CompleteInit();

    [DllImport("CaptureServiceClient.dll")]
    private static extern void PInvoke_LegacyAPIHelper_ClearCallback(
      Camera.LegacyAPIManagedEventCallback cb);

    protected object InternalLock => this._lock;

    public static bool IsCameraTypeSupported(CameraType type) => ((IEnumerable<CameraSensorLocation>) PhotoCaptureDevice.AvailableSensorLocations).Contains<CameraSensorLocation>(Camera.CameraTypeToWinRTCameraType(type));

    public CameraType CameraType { get; protected set; }

    public event EventHandler<CameraOperationCompletedEventArgs> Initialized;

    [AllowReversePInvokeCalls]
    private void RouteLegacyAPIEvent() => this.Dispose();

    internal Camera() => this._pinnedCallback = new Camera.LegacyAPIManagedEventCallback(this.RouteLegacyAPIEvent);

    internal string GetVideoPortName()
    {
      PhotoCaptureDevice photoCaptureDevice = this._photoCaptureDevice;
      return photoCaptureDevice != null ? photoCaptureDevice.GetProperty(Camera.videoPortNamePropertyGuid) as string : string.Empty;
    }

    internal void InitializeVideoSession(VideoBrush brush)
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(nameof (Camera), "Disposed objects cannot be reinitialized. Please create a new instance.");
      this._initializeAttempted = !this._initializeAttempted ? true : throw new InvalidOperationException("Already initialized. .SetSource can only be called once on camera instance.");
      new Thread((ThreadStart) (() =>
      {
        Exception exception = (Exception) null;
        try
        {
          if (!this._isDisposed)
          {
            Camera.PInvoke_LegacyAPIHelper_WaitInit(this._pinnedCallback);
            this.OpenCaptureDevice();
            this.SetAppropriatePreviewResolution(this.Resolution);
            this._previewFrameEvent = new AutoResetEvent(false);
            PhotoCaptureDevice photoCaptureDevice1 = this._photoCaptureDevice;
            if (photoCaptureDevice1 != null)
            {
              PhotoCaptureDevice photoCaptureDevice2 = photoCaptureDevice1;
              // ISSUE: method pointer
              WindowsRuntimeMarshal.AddEventHandler<TypedEventHandler<ICameraCaptureDevice, object>>((Func<M0, EventRegistrationToken>) new Func<TypedEventHandler<ICameraCaptureDevice, object>, EventRegistrationToken>(photoCaptureDevice2.add_PreviewFrameAvailable), new Action<EventRegistrationToken>(photoCaptureDevice2.remove_PreviewFrameAvailable), (M0) new TypedEventHandler<ICameraCaptureDevice, object>((object) this, __methodptr(OnPreviewFrameAvailable)));
              Deployment.Current.Dispatcher.BeginInvoke((Action) (() => brush.SetExternalVideoPortSource(this.GetVideoPortName())));
              this.PrepareCaptureSequence();
            }
          }
          else
            exception = (Exception) new ObjectDisposedException(nameof (Camera), "Initialization canceled by .Dispose().");
        }
        catch (Exception ex)
        {
          this._isDisposed = true;
          exception = ex;
        }
        finally
        {
          PhotoCaptureDevice photoCaptureDevice = this._photoCaptureDevice;
          if (this._isDisposed && photoCaptureDevice != null)
          {
            // ISSUE: method pointer
            WindowsRuntimeMarshal.RemoveEventHandler<TypedEventHandler<ICameraCaptureDevice, object>>(new Action<EventRegistrationToken>(photoCaptureDevice.remove_PreviewFrameAvailable), (M0) new TypedEventHandler<ICameraCaptureDevice, object>((object) this, __methodptr(OnPreviewFrameAvailable)));
            photoCaptureDevice.Dispose();
            this._photoCaptureDevice = (PhotoCaptureDevice) null;
          }
          if (!this._isDisposed)
            Camera.PInvoke_LegacyAPIHelper_CompleteInit();
        }
        if (this.SafeFireEvent<CameraOperationCompletedEventArgs>(this.Initialized, new CameraOperationCompletedEventArgs(exception == null, exception)) || exception == null)
          return;
        Application.OnPlatformAssemblyUnhandledException(exception, true);
      })).Start();
    }

    private void OpenCaptureDevice()
    {
      Task<PhotoCaptureDevice> task = (Task<PhotoCaptureDevice>) WindowsRuntimeSystemExtensions.AsTask<PhotoCaptureDevice>((IAsyncOperation<M0>) PhotoCaptureDevice.OpenAsync(Camera.CameraTypeToWinRTCameraType(this.CameraType), this.SizeToWindowsFoundationSize(this.Resolution)));
      ((Task) task).Wait();
      this._photoCaptureDevice = task.Result;
    }

    private void SetAppropriatePreviewResolution(System.Windows.Size captureResolution) => WindowsRuntimeSystemExtensions.AsTask(this._photoCaptureDevice.SetPreviewResolutionAsync(this.SizeToWindowsFoundationSize(this.CalculatePreviewResolutionFromResolution(captureResolution)))).Wait();

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    private void Dispose(bool disposing)
    {
      if (disposing && this._photoCaptureDevice != null)
      {
        // ISSUE: method pointer
        WindowsRuntimeMarshal.RemoveEventHandler<TypedEventHandler<ICameraCaptureDevice, object>>(new Action<EventRegistrationToken>(this._photoCaptureDevice.remove_PreviewFrameAvailable), (M0) new TypedEventHandler<ICameraCaptureDevice, object>((object) this, __methodptr(OnPreviewFrameAvailable)));
        this._photoCaptureDevice.Dispose();
        this._photoCaptureDevice = (PhotoCaptureDevice) null;
      }
      this._isDisposed = true;
      Camera.PInvoke_LegacyAPIHelper_ClearCallback(this._pinnedCallback);
    }

    ~Camera() => this.Dispose(false);

    public IEnumerable<System.Windows.Size> AvailableResolutions
    {
      get
      {
        if (this._resolutions != null)
          return (IEnumerable<System.Windows.Size>) this._resolutions;
        lock (this._lock)
        {
          if (this._resolutions != null)
            return (IEnumerable<System.Windows.Size>) this._resolutions;
          IReadOnlyCollection<Windows.Foundation.Size> captureResolutions = (IReadOnlyCollection<Windows.Foundation.Size>) PhotoCaptureDevice.GetAvailableCaptureResolutions(Camera.CameraTypeToWinRTCameraType(this.CameraType));
          this._resolutions = ((IEnumerable<System.Windows.Size>) Enumerable.OrderBy<System.Windows.Size, double>(Enumerable.Where<System.Windows.Size>((IEnumerable<M0>) ((IEnumerable<System.Windows.Size>) Enumerable.Select<Windows.Foundation.Size, System.Windows.Size>((IEnumerable<M0>) ((IEnumerable<Windows.Foundation.Size>) captureResolutions).Take<Windows.Foundation.Size>(captureResolutions.Count), (Func<M0, M1>) (x => this.WindowsFoundationSizeToSize(x)))).Distinct<System.Windows.Size>(), (Func<M0, bool>) (z => this.IsValidCaptureResolution(z))), (Func<M0, M1>) (y => y.Width * y.Height))).ToList<System.Windows.Size>().AsReadOnly();
        }
        return (IEnumerable<System.Windows.Size>) this._resolutions;
      }
    }

    private ReadOnlyCollection<System.Windows.Size> AvailablePreviewResolutions
    {
      get
      {
        if (this._previewResolutions != null)
          return this._previewResolutions;
        lock (this._lock)
        {
          if (this._previewResolutions != null)
            return this._previewResolutions;
          IReadOnlyCollection<Windows.Foundation.Size> previewResolutions = (IReadOnlyCollection<Windows.Foundation.Size>) PhotoCaptureDevice.GetAvailablePreviewResolutions(Camera.CameraTypeToWinRTCameraType(this.CameraType));
          this._previewResolutions = ((IEnumerable<System.Windows.Size>) Enumerable.OrderBy<System.Windows.Size, double>((IEnumerable<M0>) ((IEnumerable<System.Windows.Size>) Enumerable.Select<Windows.Foundation.Size, System.Windows.Size>((IEnumerable<M0>) ((IEnumerable<Windows.Foundation.Size>) previewResolutions).Take<Windows.Foundation.Size>(previewResolutions.Count), (Func<M0, M1>) (x => this.WindowsFoundationSizeToSize(x)))).Distinct<System.Windows.Size>(), (Func<M0, M1>) (y => y.Width * y.Height))).ToList<System.Windows.Size>().AsReadOnly();
        }
        return this._previewResolutions;
      }
    }

    public System.Windows.Size Resolution
    {
      set
      {
        if (!this._resolutions.Contains(value))
          throw new ArgumentException("'Resolution' may only be set to a value listed in 'AvailableResolutions'.");
        lock (this._lock)
        {
          this.ThrowExceptionIfCameraIsNotInitialized();
          System.Windows.Size? currentResolution = this._currentResolution;
          System.Windows.Size size = value;
          if ((currentResolution.HasValue ? (currentResolution.HasValue ? (currentResolution.GetValueOrDefault() != size ? 1 : 0) : 0) : 1) == 0)
            return;
          WindowsRuntimeSystemExtensions.AsTask(this._photoCaptureDevice.SetCaptureResolutionAsync(this.SizeToWindowsFoundationSize(value))).Wait();
          this.SetAppropriatePreviewResolution(value);
          this.PrepareCaptureSequence();
          this._currentResolution = new System.Windows.Size?(value);
        }
      }
      get
      {
        lock (this._lock)
        {
          if (!this._currentResolution.HasValue)
          {
            List<System.Windows.Size> sizeList = new List<System.Windows.Size>(this.AvailableResolutions);
            this._currentResolution = new System.Windows.Size?(sizeList[sizeList.Count - 1]);
          }
        }
        return this._currentResolution.Value;
      }
    }

    public System.Windows.Size PreviewResolution => this.CalculatePreviewResolutionFromResolution(this.Resolution);

    private bool IsValidCaptureResolution(System.Windows.Size captureResolution) => this.AvailablePreviewResolutions.Contains(this.CalculatePreviewResolutionFromResolution(captureResolution));

    private System.Windows.Size CalculatePreviewResolutionFromResolution(System.Windows.Size resolution)
    {
      int num = 640;
      return new System.Windows.Size((double) num, (double) (num * (int) resolution.Height / (int) resolution.Width));
    }

    protected bool SafeFireEvent(EventHandler callback)
    {
      if (callback == null)
        return false;
      ThreadPool.QueueUserWorkItem((WaitCallback) (ignored => callback((object) this, EventArgs.Empty)));
      return true;
    }

    protected bool SafeFireEvent<T>(EventHandler<T> callback, T args) where T : EventArgs
    {
      if (callback == null)
        return false;
      ThreadPool.QueueUserWorkItem((WaitCallback) (ignored => callback((object) this, args)));
      return true;
    }

    public double Orientation => 90.0;

    private Windows.Foundation.Size SizeToWindowsFoundationSize(System.Windows.Size size) => new Windows.Foundation.Size(size.Width, size.Height);

    private System.Windows.Size WindowsFoundationSizeToSize(Windows.Foundation.Size size) => new System.Windows.Size(size.Width, size.Height);

    private void PrepareCaptureSequence()
    {
      if (this._photoCaptureDevice == null)
        return;
      this._captureSequence = this._photoCaptureDevice.CreateCaptureSequence(1U);
      WindowsRuntimeSystemExtensions.AsTask(this._photoCaptureDevice.PrepareCaptureSequenceAsync(this._captureSequence)).Wait();
    }

    protected static CameraSensorLocation CameraTypeToWinRTCameraType(
      CameraType cameraType)
    {
      if (cameraType == CameraType.Primary)
        return (CameraSensorLocation) 0;
      if (cameraType == CameraType.FrontFacing)
        return (CameraSensorLocation) 1;
      throw new ArgumentException("Unexpected CameraType");
    }

    internal void ThrowExceptionIfCameraIsNotInitialized()
    {
      if (this._photoCaptureDevice == null || this._captureSequence == null)
        throw new InvalidOperationException("You cannot use this instance until it is fully initialized. You can initialize by passing this Camera object to VideoBrush.SetSource(...)");
    }

    internal void OnPreviewFrameAvailable(ICameraCaptureDevice device, object args) => this._previewFrameEvent.Set();

    private delegate void LegacyAPIManagedEventCallback();
  }
}
