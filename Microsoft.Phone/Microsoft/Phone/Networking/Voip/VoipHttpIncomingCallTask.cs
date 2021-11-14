// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Networking.Voip.VoipHttpIncomingCallTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Scheduler;
using System;
using System.Security;

namespace Microsoft.Phone.Networking.Voip
{
  [SecuritySafeCritical]
  public sealed class VoipHttpIncomingCallTask : ScheduledTask
  {
    private string _channelName;
    private byte[] _pushRawMessage;

    public VoipHttpIncomingCallTask(string name, string channelName)
      : base(name, ScheduledActionType.VoipHttpIncomingCallTask)
    {
      this._channelName = channelName;
    }

    public string ChannelName
    {
      get => this._channelName;
      internal set => this._channelName = value;
    }

    public byte[] MessageBody
    {
      get => this._pushRawMessage;
      internal set => this._pushRawMessage = value;
    }

    internal VoipHttpIncomingCallTask(VoipHttpIncomingCallTask agent)
      : base((ScheduledTask) agent)
    {
      this._channelName = agent.ChannelName;
      this._pushRawMessage = agent.MessageBody;
    }

    internal override ScheduledAction CreateCopy() => (ScheduledAction) new VoipHttpIncomingCallTask(this);

    internal override void UpdateStatusFrom(ScheduledAction action)
    {
      this.ChannelName = action is VoipHttpIncomingCallTask incomingCallTask ? incomingCallTask.ChannelName : throw new ArgumentException("'action' must be a type of 'VoipHttpIncomingCallTask'", nameof (action));
      this.MessageBody = incomingCallTask.MessageBody;
      base.UpdateStatusFrom(action);
    }
  }
}
