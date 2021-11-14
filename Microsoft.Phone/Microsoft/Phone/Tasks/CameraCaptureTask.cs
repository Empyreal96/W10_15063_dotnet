// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.CameraCaptureTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;

namespace Microsoft.Phone.Tasks
{
  public sealed class CameraCaptureTask : ChooserBase<PhotoResult>
  {
    private const string cameraCapturePrefix = "CameraCapture-";

    public override void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      this.Show(this.BuildUri(), this.BuildParameterPropertyBag());
    }

    internal override Uri BuildUri() => new Uri("microsoft.windows.camera.picker:", UriKind.Absolute);

    internal override ParameterPropertyBag BuildParameterPropertyBag()
    {
      ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag();
      parameterPropertyBag.CreateProperty("MediaType").StringValue = "photo";
      return parameterPropertyBag;
    }

    internal override void OnInvokeReturned(byte[] outputBuffer, Delegate fireThisHandlerOnly)
    {
      bool flag = false;
      Exception exception = (Exception) null;
      if (outputBuffer.Length != 0)
      {
        byte[] buffer = outputBuffer;
        ParameterPropertyBag ppb = new ParameterPropertyBag(buffer, (uint) buffer.Length);
        ParameterProperty property1 = ppb.GetProperty("Status");
        if (property1.ValueType == ParameterPropertyValueType.ValueType_String && !string.IsNullOrEmpty(property1.StringValue))
        {
          if (string.Compare(property1.StringValue, "OK") == 0)
          {
            Task<PhotoResult> photoResult = ChooserHelper.PropertyBagToPhotoResult(ppb, "CameraCapture-", false);
            ((Task) photoResult).Wait();
            PhotoResult result = photoResult.Result;
            if (result != null)
            {
              flag = true;
              result.TaskResult = TaskResult.OK;
              this.FireCompleted((object) this, result, fireThisHandlerOnly);
            }
          }
          else if (string.Compare(property1.StringValue, "ERROR") == 0)
          {
            ParameterProperty property2 = ppb.GetProperty("ErrorCode");
            if (property2.ValueType == ParameterPropertyValueType.ValueType_String && string.Compare(property2.StringValue, "SYNCING") == 0)
              exception = (Exception) new InvalidOperationException("");
          }
        }
        GC.KeepAlive((object) ppb);
      }
      if (flag)
        return;
      PhotoResult e = new PhotoResult(TaskResult.Cancel);
      if (!QuirksMode.ShouldNotSetPhotoResultErrorCode())
        e.Error = exception;
      this.FireCompleted((object) this, e, fireThisHandlerOnly);
    }

    internal override ChooserLaunchType LaunchType => ChooserLaunchType.ModernChooser;

    internal override string ChooserTargetPackageFamilyName => CameraCaptureTask.GetCameraPackageFamilyName();

    [SecuritySafeCritical]
    private static string GetCameraPackageFamilyName()
    {
      string packageFamilyName;
      int installedCameraPfn = (int) CameraCaptureTask.GetInstalledCameraPFN(out packageFamilyName);
      return packageFamilyName;
    }

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    private static extern uint GetInstalledCameraPFN([MarshalAs(UnmanagedType.LPWStr)] out string packageFamilyName);
  }
}
