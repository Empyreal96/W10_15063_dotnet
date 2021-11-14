// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Networking.Voip.VoipCallInProgressAgent
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.BackgroundAgentSharedConsts;
using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Networking.Voip
{
  public abstract class VoipCallInProgressAgent : BackgroundAgent
  {
    private VoipCallInProgressAgentLaunchReason _launchReason;

    protected abstract void OnFirstCallStarting();

    protected VoipCallInProgressAgentLaunchReason LaunchReason => this._launchReason;

    internal override void Invoke(Uri uri, ParameterPropertyBag parameters)
    {
      bool flag = false;
      ParameterProperty property = parameters.GetProperty("VoIPAgentLaunchReason");
      if (property == null || property.ValueType != ParameterPropertyValueType.ValueType_UInt32)
      {
        flag = true;
      }
      else
      {
        switch ((VoIPAgentLaunchReason) property.UInt32Value)
        {
          case VoIPAgentLaunchReason.VOIPAGENT_LAUNCH_CALLSTART:
            this._launchReason = VoipCallInProgressAgentLaunchReason.CallStart;
            break;
          case VoIPAgentLaunchReason.VOIPAGENT_LAUNCH_CALLQUERY:
            this._launchReason = VoipCallInProgressAgentLaunchReason.CallQuery;
            break;
          default:
            flag = true;
            break;
        }
      }
      if (flag)
        throw new ArgumentException("Invalid property in parameter property bag.", "VoIPAgentLaunchReason");
      this.OnFirstCallStarting();
    }
  }
}
