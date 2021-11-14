// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ShareMediaTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Security;

namespace Microsoft.Phone.Tasks
{
  public sealed class ShareMediaTask
  {
    public string FilePath { get; set; }

    [SecuritySafeCritical]
    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      ChooserHelper.LaunchChildTask(this.BuildUri(), this.BuildParameterPropertyBag());
    }

    private Uri BuildUri() => new Uri("app://5B04B775-356B-4AA0-AAF8-6491FFEA5901/ShareMedia", UriKind.Absolute);

    private ParameterPropertyBag BuildParameterPropertyBag()
    {
      ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag();
      parameterPropertyBag.CreateProperty("FilePath").StringValue = this.FilePath;
      return parameterPropertyBag;
    }
  }
}
