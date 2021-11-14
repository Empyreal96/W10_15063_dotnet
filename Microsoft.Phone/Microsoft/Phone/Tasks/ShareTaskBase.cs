// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ShareTaskBase
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Tasks
{
  public abstract class ShareTaskBase
  {
    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      ChooserHelper.LaunchChildTask(this.BuildUri(), this.BuildParameterPropertyBag());
    }

    internal Uri BuildUri() => new Uri("app://5B04B775-356B-4AA0-AAF8-6491FFEA5901/ShareContent", UriKind.Absolute);

    internal abstract ParameterPropertyBag BuildParameterPropertyBag();

    [Flags]
    internal enum ShareMethod
    {
      SHAREMETHOD_SEND = 3,
      SHAREMETHOD_POST_LINK = 4,
      SHAREMETHOD_POST_STATUS = 8,
      SHAREMETHOD_LINK_TASK = SHAREMETHOD_POST_LINK | SHAREMETHOD_SEND, // 0x00000007
      SHAREMETHOD_STATUS_TASK = SHAREMETHOD_POST_STATUS | SHAREMETHOD_SEND, // 0x0000000B
    }
  }
}
