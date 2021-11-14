// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.NetworkOperators.IncomingMobileNetworkMessageTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Scheduler;
using System;
using System.Security;

namespace Microsoft.Phone.NetworkOperators
{
  [SecuritySafeCritical]
  public sealed class IncomingMobileNetworkMessageTask : ScheduledTask
  {
    private byte[] _nabMessageHeader;
    private byte[] _nabMessageBody;
    private byte[] _nabMessageDigest;

    public IncomingMobileNetworkMessageTask(string name)
      : base(name, ScheduledActionType.IncomingMobileNetworkMessageTask)
    {
    }

    public byte[] Header
    {
      get => this._nabMessageHeader;
      internal set => this._nabMessageHeader = value;
    }

    public byte[] Body
    {
      get => this._nabMessageBody;
      internal set => this._nabMessageBody = value;
    }

    public byte[] Digest
    {
      get => this._nabMessageDigest;
      internal set => this._nabMessageDigest = value;
    }

    internal IncomingMobileNetworkMessageTask(IncomingMobileNetworkMessageTask agent)
      : base((ScheduledTask) agent)
    {
    }

    internal override ScheduledAction CreateCopy() => (ScheduledAction) new IncomingMobileNetworkMessageTask(this);

    internal override void UpdateStatusFrom(ScheduledAction action)
    {
      this.Header = action is IncomingMobileNetworkMessageTask networkMessageTask ? networkMessageTask.Header : throw new ArgumentException("'action' must be a type of 'IncomingMobileNetworkMessageTask'", nameof (action));
      this.Body = networkMessageTask.Body;
      this.Digest = networkMessageTask.Digest;
      base.UpdateStatusFrom(action);
    }
  }
}
