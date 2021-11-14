// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ShareLinkTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Tasks
{
  public sealed class ShareLinkTask : ShareTaskBase
  {
    public Uri LinkUri { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    internal override ParameterPropertyBag BuildParameterPropertyBag()
    {
      ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag();
      parameterPropertyBag.CreateProperty("WebLink").StringValue = this.LinkUri.IsAbsoluteUri ? this.LinkUri.AbsoluteUri : throw new ArgumentOutOfRangeException("The shared link has to be an absolute Uri.");
      parameterPropertyBag.CreateProperty("Body").StringValue = this.LinkUri.AbsoluteUri;
      if (!string.IsNullOrEmpty(this.Title))
        parameterPropertyBag.CreateProperty("Subject").StringValue = this.Title;
      if (!string.IsNullOrEmpty(this.Message))
        parameterPropertyBag.CreateProperty("Description").StringValue = this.Message;
      parameterPropertyBag.CreateProperty("ShareMethod").Int32Value = 7;
      return parameterPropertyBag;
    }
  }
}
