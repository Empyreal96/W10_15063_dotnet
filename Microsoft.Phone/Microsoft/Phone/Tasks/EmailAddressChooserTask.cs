// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.EmailAddressChooserTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Tasks
{
  public sealed class EmailAddressChooserTask : ChooserBase<EmailResult>
  {
    public override void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      this.Show(this.BuildUri(), this.BuildParameterPropertyBag());
    }

    internal override Uri BuildUri() => new Uri("ms-people:picker?", UriKind.Absolute);

    internal override ParameterPropertyBag BuildParameterPropertyBag()
    {
      ParameterPropertyBag parameterPropertyBag = new ParameterPropertyBag();
      parameterPropertyBag.CreateProperty("ReturnRawValue").BoolValue = true;
      parameterPropertyBag.CreateProperty("DesiredFields").StringValue = "Email";
      return parameterPropertyBag;
    }

    internal override void OnInvokeReturned(byte[] outputBuffer, Delegate fireThisHandlerOnly)
    {
      bool flag = false;
      if (outputBuffer.Length != 0)
      {
        byte[] buffer = outputBuffer;
        ParameterPropertyBag ppb = new ParameterPropertyBag(buffer, (uint) buffer.Length);
        ParameterProperty property = ppb.GetProperty("Email");
        if (property.ValueType == ParameterPropertyValueType.ValueType_String && !string.IsNullOrEmpty(property.StringValue))
        {
          flag = true;
          this.FireCompleted((object) this, new EmailResult(TaskResult.OK)
          {
            Email = property.StringValue,
            DisplayName = this.GetDisplayName(ppb)
          }, fireThisHandlerOnly);
        }
        GC.KeepAlive((object) ppb);
      }
      if (flag)
        return;
      this.FireCompleted((object) this, new EmailResult(TaskResult.Cancel), fireThisHandlerOnly);
    }

    internal override ChooserLaunchType LaunchType => ChooserLaunchType.ModernChooser;

    internal override string ChooserTargetPackageFamilyName => "Microsoft.People_8wekyb3d8bbwe";
  }
}
