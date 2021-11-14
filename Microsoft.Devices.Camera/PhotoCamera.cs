// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.PhotoCamera
// Assembly: Microsoft.Devices.Camera, Version=0.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: EF9A4555-242B-4723-B191-4FF24D598391
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI27EF~1.DLL

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Windows.Foundation;
using Windows.Phone.Media.Capture;

namespace Microsoft.Devices
{
  public sealed class PhotoCamera : Camera
  {
    private FlashMode? _flashMode;
    private bool _isCapturing;
    private MemoryStream _capturedImageStream;
    private MemoryStream _capturedThumbnailStream;
    private IAsyncAction _startCaptureAsyncAction;
    private IAsyncOperation<CameraFocusStatus> _startFocusOperation;
    private List<FlashMode> _supportedFlashModes;
    private const int _previewFrameTimeout = 500;
    private bool _CaptureThumbnailAvailableEventDelivered;
    private bool _CaptureImageAvailableEventDelivered;

    public PhotoCamera(CameraType type) => this.CameraType = type;

    public PhotoCamera() => this.CameraType = CameraType.Primary;

    public event EventHandler<CameraOperationCompletedEventArgs> AutoFocusCompleted;

    public event EventHandler CaptureStarted;

    public event EventHandler<ContentReadyEventArgs> CaptureThumbnailAvailable;

    public event EventHandler<ContentReadyEventArgs> CaptureImageAvailable;

    public event EventHandler<CameraOperationCompletedEventArgs> CaptureCompleted;

    public bool IsFocusSupported => PhotoCaptureDevice.IsFocusSupported(Camera.CameraTypeToWinRTCameraType(this.CameraType));

    public void Focus()
    {
      lock (this.InternalLock)
      {
        this.CheckInitAndCaptureComplete();
        if (!this.IsFocusSupported || this._startFocusOperation != null)
          return;
        this._photoCaptureDevice.put_FocusRegion(new Windows.Foundation.Rect?());
        this._startFocusOperation = this._photoCaptureDevice.FocusAsync();
        IAsyncOperation<CameraFocusStatus> startFocusOperation = this._startFocusOperation;
        // ISSUE: method pointer
        startFocusOperation.put_Completed((AsyncOperationCompletedHandler<CameraFocusStatus>) Delegate.Combine((Delegate) startFocusOperation.Completed, (Delegate) new AsyncOperationCompletedHandler<CameraFocusStatus>((object) this, __methodptr(OnStartFocusComplete))));
      }
    }

    private void OnStartFocusComplete(IAsyncOperation<CameraFocusStatus> operation, AsyncStatus e)
    {
      lock (this.InternalLock)
        this._startFocusOperation = (IAsyncOperation<CameraFocusStatus>) null;
      if (e == 1)
        this.SafeFireEvent<CameraOperationCompletedEventArgs>(this.AutoFocusCompleted, new CameraOperationCompletedEventArgs(true, (Exception) null));
      else
        this.SafeFireEvent<CameraOperationCompletedEventArgs>(this.AutoFocusCompleted, new CameraOperationCompletedEventArgs(false, (Exception) null));
    }

    public bool IsFocusAtPointSupported => PhotoCaptureDevice.IsFocusRegionSupported(Camera.CameraTypeToWinRTCameraType(this.CameraType));

    public void FocusAtPoint(double x, double y)
    {
      if (x < 0.0 || x > 1.0 || (y < 0.0 || y > 1.0))
        throw new ArgumentException("'x' and 'y' must be a percentage (represented as a value between 0 and 1)");
      lock (this.InternalLock)
      {
        this.CheckInitAndCaptureComplete();
        if (!this.IsFocusAtPointSupported)
          return;
        Windows.Foundation.Rect rect;
        ref Windows.Foundation.Rect local = ref rect;
        double num1 = x;
        System.Windows.Size previewResolution = this.PreviewResolution;
        double width = previewResolution.Width;
        double x1 = num1 * width;
        double num2 = y;
        previewResolution = this.PreviewResolution;
        double height = previewResolution.Height;
        double y1 = num2 * height;
        local = new Windows.Foundation.Rect(x1, y1, 0.0, 0.0);
        this._photoCaptureDevice.put_FocusRegion(new Windows.Foundation.Rect?(rect));
        this._startFocusOperation = this._photoCaptureDevice.FocusAsync();
        IAsyncOperation<CameraFocusStatus> startFocusOperation = this._startFocusOperation;
        // ISSUE: method pointer
        startFocusOperation.put_Completed((AsyncOperationCompletedHandler<CameraFocusStatus>) Delegate.Combine((Delegate) startFocusOperation.Completed, (Delegate) new AsyncOperationCompletedHandler<CameraFocusStatus>((object) this, __methodptr(OnStartFocusComplete))));
      }
    }

    public void CancelFocus()
    {
      lock (this.InternalLock)
      {
        this.CheckInitAndCaptureComplete();
        if (this._startFocusOperation == null)
          return;
        ((IAsyncInfo) this._startFocusOperation).Cancel();
      }
    }

    private void CheckInitAndCaptureComplete()
    {
      this.ThrowExceptionIfCameraIsNotInitialized();
      if (this._isCapturing)
        throw new InvalidOperationException("Cannot be called until capture has completed.");
    }

    public void GetPreviewBufferArgb32(int[] pixelData)
    {
      lock (this.InternalLock)
        this.CheckInitAndCaptureComplete();
      this._previewFrameEvent.WaitOne(500);
      lock (this.InternalLock)
      {
        this.CheckInitAndCaptureComplete();
        this._photoCaptureDevice.GetPreviewBufferArgb(pixelData);
      }
    }

    public void GetPreviewBufferY(byte[] pixelData)
    {
      lock (this.InternalLock)
        this.CheckInitAndCaptureComplete();
      this._previewFrameEvent.WaitOne(500);
      lock (this.InternalLock)
      {
        this.CheckInitAndCaptureComplete();
        this._photoCaptureDevice.GetPreviewBufferY(pixelData);
      }
    }

    public YCbCrPixelLayout YCbCrPixelLayout
    {
      get
      {
        YCbCrPixelLayout ycbCrPixelLayout = new YCbCrPixelLayout();
        System.Windows.Size previewResolution1 = this.PreviewResolution;
        int width1 = (int) previewResolution1.Width;
        previewResolution1 = this.PreviewResolution;
        int height1 = (int) previewResolution1.Height;
        ycbCrPixelLayout.CbOffset = width1 * height1;
        ycbCrPixelLayout.CbPitch = (int) this.PreviewResolution.Width;
        ycbCrPixelLayout.CbXPitch = 2;
        System.Windows.Size previewResolution2 = this.PreviewResolution;
        int width2 = (int) previewResolution2.Width;
        previewResolution2 = this.PreviewResolution;
        int height2 = (int) previewResolution2.Height;
        ycbCrPixelLayout.CrOffset = width2 * height2 + 1;
        ycbCrPixelLayout.CrPitch = (int) this.PreviewResolution.Width;
        ycbCrPixelLayout.CrXPitch = 2;
        System.Windows.Size previewResolution3 = this.PreviewResolution;
        int width3 = (int) previewResolution3.Width;
        previewResolution3 = this.PreviewResolution;
        int height3 = (int) previewResolution3.Height;
        ycbCrPixelLayout.RequiredBufferSize = width3 * height3 * 3 / 2;
        ycbCrPixelLayout.YOffset = 0;
        ycbCrPixelLayout.YPitch = (int) this.PreviewResolution.Width;
        ycbCrPixelLayout.YXPitch = 1;
        return ycbCrPixelLayout;
      }
    }

    public void GetPreviewBufferYCbCr(byte[] pixelData)
    {
      lock (this.InternalLock)
        this.CheckInitAndCaptureComplete();
      this._previewFrameEvent.WaitOne(500);
      lock (this.InternalLock)
      {
        this.CheckInitAndCaptureComplete();
        this._photoCaptureDevice.GetPreviewBufferYCbCr(pixelData);
      }
    }

    public bool IsFlashModeSupported(FlashMode mode)
    {
      lock (this.InternalLock)
      {
        if (this._supportedFlashModes == null)
        {
          this._supportedFlashModes = new List<FlashMode>();
          foreach (uint supportedPropertyValue in (IEnumerable<object>) PhotoCaptureDevice.GetSupportedPropertyValues(Camera.CameraTypeToWinRTCameraType(this.CameraType), KnownCameraPhotoProperties.FlashMode))
            this._supportedFlashModes.Add(this.FlashStateToFlashMode((FlashState) (int) supportedPropertyValue));
        }
      }
      return this._supportedFlashModes.Contains(mode);
    }

    public FlashMode FlashMode
    {
      get
      {
        if (!this._flashMode.HasValue)
          this.FlashMode = !this.IsFlashModeSupported(FlashMode.Auto) ? FlashMode.Off : FlashMode.Auto;
        return this._flashMode.Value;
      }
      set
      {
        if (this.IsFlashModeSupported(value))
        {
          this.CheckInitAndCaptureComplete();
          this._photoCaptureDevice.SetProperty(KnownCameraPhotoProperties.FlashMode, (object) (uint) this.FlashModeToFlashState(value));
        }
        this._flashMode = new FlashMode?(value);
      }
    }

    public void CaptureImage()
    {
      lock (this.InternalLock)
      {
        this.CheckInitAndCaptureComplete();
        if (this._startFocusOperation != null)
          ((IAsyncInfo) this._startFocusOperation).Cancel();
        this._CaptureThumbnailAvailableEventDelivered = false;
        this._CaptureImageAvailableEventDelivered = false;
        this._capturedImageStream = new MemoryStream();
        this._capturedThumbnailStream = new MemoryStream();
        this._captureSequence.Frames[0].put_CaptureStream(WindowsRuntimeStreamExtensions.AsOutputStream((Stream) this._capturedImageStream));
        this._captureSequence.Frames[0].put_ThumbnailStream(WindowsRuntimeStreamExtensions.AsOutputStream((Stream) this._capturedThumbnailStream));
        this._startCaptureAsyncAction = this._captureSequence.StartCaptureAsync();
        IAsyncAction captureAsyncAction = this._startCaptureAsyncAction;
        // ISSUE: method pointer
        captureAsyncAction.put_Completed((AsyncActionCompletedHandler) Delegate.Combine((Delegate) captureAsyncAction.Completed, (Delegate) new AsyncActionCompletedHandler((object) this, __methodptr(OnCaptureComplete))));
        this.SafeFireEvent(this.CaptureStarted);
        this._isCapturing = true;
      }
    }

    private void OnCaptureComplete(IAsyncAction action, AsyncStatus e)
    {
      lock (this.InternalLock)
      {
        this._startCaptureAsyncAction = (IAsyncAction) null;
        if (e == 1)
        {
          this._capturedThumbnailStream.Seek(0L, SeekOrigin.Begin);
          this._capturedImageStream.Seek(0L, SeekOrigin.Begin);
          this.SafeFireContentReadyEvent(this.CaptureThumbnailAvailable, this._capturedThumbnailStream, PhotoCamera.ContentReadyType.Thumbnail);
          this.SafeFireContentReadyEvent(this.CaptureImageAvailable, this._capturedImageStream, PhotoCamera.ContentReadyType.Image);
        }
        else
          this.SafeFireEvent<CameraOperationCompletedEventArgs>(this.CaptureCompleted, new CameraOperationCompletedEventArgs(false, this.GetErrorException(action)));
      }
    }

    private FlashMode FlashStateToFlashMode(FlashState flashState)
    {
      switch ((int) flashState)
      {
        case 0:
          return FlashMode.Off;
        case 1:
          return FlashMode.Auto;
        case 3:
          return FlashMode.On;
        default:
          throw new ArgumentException("Invalid FlashState: " + (object) flashState);
      }
    }

    private FlashState FlashModeToFlashState(FlashMode flashMode)
    {
      switch (flashMode)
      {
        case FlashMode.On:
          return (FlashState) 3;
        case FlashMode.Off:
          return (FlashState) 0;
        case FlashMode.Auto:
          return (FlashState) 1;
        default:
          throw new ArgumentException("Invalid FlashMode: " + (object) flashMode);
      }
    }

    private Exception GetErrorException(IAsyncAction action)
    {
      try
      {
        action.GetResults();
        return (Exception) null;
      }
      catch (Exception ex)
      {
        return ex;
      }
    }

    private void SafeFireContentReadyEvent(
      EventHandler<ContentReadyEventArgs> callback,
      MemoryStream stream,
      PhotoCamera.ContentReadyType contentType)
    {
      ThreadPool.QueueUserWorkItem((WaitCallback) (ignored =>
      {
        try
        {
          if (callback == null)
            return;
          callback((object) this, new ContentReadyEventArgs((Stream) stream));
        }
        finally
        {
          switch (contentType)
          {
            case PhotoCamera.ContentReadyType.Thumbnail:
              this._CaptureThumbnailAvailableEventDelivered = true;
              break;
            case PhotoCamera.ContentReadyType.Image:
              this._CaptureImageAvailableEventDelivered = true;
              break;
          }
          this.MaybeFireCaptureComplete();
        }
      }));
    }

    private void MaybeFireCaptureComplete()
    {
      bool flag = false;
      lock (this.InternalLock)
      {
        if (this._CaptureThumbnailAvailableEventDelivered)
        {
          if (this._CaptureImageAvailableEventDelivered)
          {
            flag = true;
            this._isCapturing = false;
            this._CaptureThumbnailAvailableEventDelivered = false;
            this._CaptureImageAvailableEventDelivered = false;
          }
        }
      }
      if (!flag || this.CaptureCompleted == null)
        return;
      this.CaptureCompleted((object) this, new CameraOperationCompletedEventArgs(true, (Exception) null));
    }

    private enum ContentReadyType
    {
      Invalid,
      Thumbnail,
      Image,
    }
  }
}
