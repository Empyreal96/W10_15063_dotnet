// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.GameInviteTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.System;

namespace Microsoft.Phone.Tasks
{
  public sealed class GameInviteTask : ChooserBase<TaskEventArgs>
  {
    public string SessionId { get; set; }

    [SecuritySafeCritical]
    public override void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      Task<M0> task = WindowsRuntimeSystemExtensions.AsTask<bool>((IAsyncOperation<M0>) Launcher.LaunchUriAsync(new Uri(this.BuildUriString())));
      ((Task) task).Wait();
      if (((Task<bool>) task).Result)
        this.FireOnInvokeReturned(new byte[1]);
      else
        this.FireOnInvokeReturned((byte[]) null);
    }

    private string BuildUriString()
    {
      HostInfo hostInfo = new HostInfo();
      return string.Format("xboxgames://invite?sessionId={0}&gameId={1}&productId={2}", (object) HttpUtility.UrlEncode(this.SessionId), (object) HttpUtility.UrlEncode(GameInviteTask.NativeMethods.GF_GetCurrentGameId().ToString()), (object) HttpUtility.UrlEncode(hostInfo.ProductId));
    }

    internal override void OnInvokeReturned(byte[] outputBuffer, Delegate fireThisHandlerOnly)
    {
      if (outputBuffer != null && outputBuffer.Length != 0)
        this.FireCompleted((object) this, new TaskEventArgs(TaskResult.OK), fireThisHandlerOnly);
      else
        this.FireCompleted((object) this, new TaskEventArgs(TaskResult.Cancel), fireThisHandlerOnly);
    }

    private static class NativeMethods
    {
      [SecuritySafeCritical]
      [DllImport("zmf_client.dll")]
      public static extern uint GF_GetCurrentGameId();
    }
  }
}
