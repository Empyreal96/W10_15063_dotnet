// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.SaveEmailAddressTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Text;

namespace Microsoft.Phone.Tasks
{
  public sealed class SaveEmailAddressTask : ChooserBase<TaskEventArgs>
  {
    public string Email { get; set; }

    public override void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      this.Show(this.BuildUri(), this.BuildParameterPropertyBag());
    }

    internal override Uri BuildUri()
    {
      StringBuilder stringBuilder = new StringBuilder("ms-people:savetocontact?");
      stringBuilder.Append("Email");
      stringBuilder.Append("=");
      stringBuilder.Append(Uri.EscapeDataString(this.Email));
      return new Uri(stringBuilder.ToString(), UriKind.Absolute);
    }

    internal override ParameterPropertyBag BuildParameterPropertyBag() => new ParameterPropertyBag();

    internal override void OnInvokeReturned(byte[] outputBuffer, Delegate fireThisHandlerOnly)
    {
      if (outputBuffer != null && outputBuffer.Length != 0)
        this.FireCompleted((object) this, new TaskEventArgs(TaskResult.OK), fireThisHandlerOnly);
      else
        this.FireCompleted((object) this, new TaskEventArgs(TaskResult.Cancel), fireThisHandlerOnly);
    }

    internal override ChooserLaunchType LaunchType => ChooserLaunchType.ModernChooser;

    internal override string ChooserTargetPackageFamilyName => "Microsoft.People_8wekyb3d8bbwe";
  }
}
