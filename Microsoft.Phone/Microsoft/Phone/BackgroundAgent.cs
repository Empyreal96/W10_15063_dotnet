// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAgent
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.ComponentModel;

namespace Microsoft.Phone
{
  public abstract class BackgroundAgent
  {
    internal const int E_AIM_AGENT_CALLS_ABORT = -2147220721;

    protected internal BackgroundAgent()
    {
    }

    internal abstract void Invoke(Uri uri, ParameterPropertyBag parameters);

    protected void NotifyComplete() => this.FireRequestComplete(0);

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected void NotifyCompleteWithResult(int result) => this.FireRequestComplete(result);

    protected void Abort() => this.FireRequestComplete(-2147220721);

    protected internal virtual void OnCancel()
    {
    }

    internal event AgentRequestCompleteEventHandler RequestComplete;

    internal void FireRequestComplete(int result)
    {
      AgentRequestCompleteEventHandler requestComplete = this.RequestComplete;
      if (requestComplete == null)
        return;
      requestComplete((object) this, new AgentRequestCompleteEventArgs(result));
    }
  }
}
