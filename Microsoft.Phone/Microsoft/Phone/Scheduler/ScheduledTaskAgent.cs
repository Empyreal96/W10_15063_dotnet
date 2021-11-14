// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Scheduler.ScheduledTaskAgent
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Scheduler
{
  public abstract class ScheduledTaskAgent : BackgroundAgent
  {
    private void CheckParameterProperty(
      ParameterProperty property,
      ParameterPropertyValueType type,
      string name)
    {
      if (property == null || property.ValueType != type)
        throw new ArgumentException("Invalid property in parameter prop bag", name);
    }

    internal override void Invoke(Uri uri, ParameterPropertyBag parameters)
    {
      ParameterProperty property1 = parameters.GetProperty("name");
      ParameterProperty property2 = parameters.GetProperty("type");
      ParameterProperty property3 = parameters.GetProperty("state");
      ParameterProperty property4 = parameters.GetProperty("id");
      ParameterProperty property5 = parameters.GetProperty("content");
      ParameterProperty property6 = parameters.GetProperty("lastScheduledTime");
      ParameterProperty property7 = parameters.GetProperty("endTime");
      ParameterProperty property8 = parameters.GetProperty("lastExitReason");
      ParameterProperty property9 = parameters.GetProperty("pushChannelName");
      ParameterProperty property10 = parameters.GetProperty("pushRawMessage");
      ParameterProperty property11 = parameters.GetProperty("nabSyncHeader");
      ParameterProperty property12 = parameters.GetProperty("nabSyncBody");
      ParameterProperty property13 = parameters.GetProperty("nabSyncDigest");
      ParameterProperty property14 = parameters.GetProperty("contractOperationId");
      ParameterProperty property15 = parameters.GetProperty("isSocialAppContract");
      this.CheckParameterProperty(property1, ParameterPropertyValueType.ValueType_String, "name");
      this.CheckParameterProperty(property2, ParameterPropertyValueType.ValueType_UInt32, "type");
      this.CheckParameterProperty(property3, ParameterPropertyValueType.ValueType_UInt32, "state");
      this.CheckParameterProperty(property4, ParameterPropertyValueType.ValueType_String, "id");
      this.CheckParameterProperty(property5, ParameterPropertyValueType.ValueType_String, "content");
      this.CheckParameterProperty(property6, ParameterPropertyValueType.ValueType_UInt64, "lastScheduledTime");
      this.CheckParameterProperty(property7, ParameterPropertyValueType.ValueType_UInt64, "endTime");
      this.CheckParameterProperty(property8, ParameterPropertyValueType.ValueType_Int32, "lastExitReason");
      string pushChannel = property9.ValueType == ParameterPropertyValueType.ValueType_String ? property9.StringValue : (string) null;
      byte[] pushRawMessage = property10.ValueType == ParameterPropertyValueType.ValueType_Buffer ? property10.BufferValue : (byte[]) null;
      byte[] nabHeader = property11.ValueType == ParameterPropertyValueType.ValueType_Buffer ? property11.BufferValue : (byte[]) null;
      byte[] nabBody = property12.ValueType == ParameterPropertyValueType.ValueType_Buffer ? property12.BufferValue : (byte[]) null;
      byte[] nabDigest = property13.ValueType == ParameterPropertyValueType.ValueType_Buffer ? property13.BufferValue : (byte[]) null;
      Guid result = Guid.Empty;
      bool isSocialContract = false;
      if (property14 != null && property14.ValueType == ParameterPropertyValueType.ValueType_String)
      {
        Guid.TryParse(property14.StringValue, out result);
        if (property15 != null && property15.ValueType == ParameterPropertyValueType.ValueType_Bool)
          isSocialContract = property15.BoolValue;
      }
      this.OnInvoke(SystemNotificationInterop.CreateManagedScheduleAgentFromNative(property4.StringValue, property1.StringValue, property2.UInt32Value, property3.UInt32Value, property5.StringValue, DateTime.FromFileTimeUtc((long) property6.UInt64Value), DateTime.FromFileTime((long) property7.UInt64Value), property8.Int32Value, pushChannel, pushRawMessage, nabHeader, nabBody, nabDigest, result, isSocialContract));
    }

    protected internal abstract void OnInvoke(ScheduledTask task);

    protected internal override void OnCancel() => this.NotifyComplete();
  }
}
