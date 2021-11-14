// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.DeviceManufacturers.ServiceAgent
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.ComponentModel;

namespace Microsoft.Phone.DeviceManufacturers
{
  public abstract class ServiceAgent : BackgroundAgent
  {
    protected abstract void OnBoot();

    protected abstract void OnRestartAfterUpdate();

    protected abstract void OnRestartAfterUnexpectedTermination();

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override sealed void OnCancel() => this.NotifyComplete();

    internal override void Invoke(Uri uri, ParameterPropertyBag parameters)
    {
      bool flag = false;
      ParameterProperty property = parameters.GetProperty("LaunchMethod");
      if (property == null || property.ValueType != ParameterPropertyValueType.ValueType_UInt32)
      {
        flag = true;
      }
      else
      {
        switch (property.UInt32Value)
        {
          case 0:
            this.OnBoot();
            break;
          case 1:
            this.OnRestartAfterUnexpectedTermination();
            break;
          case 2:
            this.OnRestartAfterUpdate();
            break;
          default:
            flag = true;
            break;
        }
      }
      if (flag)
        throw new ArgumentException("Invalid property in parameter property bag.", "LaunchMethod");
    }
  }
}
