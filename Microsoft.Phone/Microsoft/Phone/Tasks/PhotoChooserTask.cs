// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.PhotoChooserTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.IO;
using System.Security;
using System.Threading.Tasks;

namespace Microsoft.Phone.Tasks
{
  public sealed class PhotoChooserTask : ChooserBase<PhotoResult>
  {
    private const string photoChooserPrefix = "PhotoChooser-";

    public int PixelHeight { get; set; }

    public int PixelWidth { get; set; }

    public bool ShowCamera { get; set; }

    [SecuritySafeCritical]
    public override void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      this.Show(this.BuildUri(), this.BuildParameterPropertyBag());
    }

    internal override Uri BuildUri() => new Uri("microsoft.windows.photos.picker:", UriKind.Absolute);

    [SecuritySafeCritical]
    internal override ParameterPropertyBag BuildParameterPropertyBag()
    {
      ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag();
      int pixelWidth = this.PixelWidth;
      int pixelHeight = this.PixelHeight;
      if (pixelWidth > 0 && pixelHeight > 0)
      {
        string newFilepath = ChooserHelper.GetNewFilepath("PhotoChooser-", ".jpg");
        using (File.Create(newFilepath))
          ;
        string destinationToken = ChooserHelper.CreateDestinationToken(newFilepath);
        parameterPropertyBag.CreateProperty("CropWidthPixels").Int32Value = pixelWidth;
        parameterPropertyBag.CreateProperty("CropHeightPixels").Int32Value = pixelHeight;
        parameterPropertyBag.CreateProperty("DestinationToken").StringValue = destinationToken;
      }
      parameterPropertyBag.CreateProperty("ShowCamera").BoolValue = this.ShowCamera;
      parameterPropertyBag.CreateProperty("uix_internal:TransitionFromPrevious").Int32Value = 3;
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
            bool shouldDeleteFile = this.PixelWidth > 0 && this.PixelHeight > 0;
            Task<PhotoResult> photoResult = ChooserHelper.PropertyBagToPhotoResult(ppb, "PhotoChooser-", shouldDeleteFile);
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
              exception = (Exception) new InvalidOperationException();
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

    internal override string ChooserTargetPackageFamilyName => "Microsoft.Windows.Photos_8wekyb3d8bbwe";
  }
}
