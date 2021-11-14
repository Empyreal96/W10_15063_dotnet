// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.GameInviteTaskNoResult
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Tasks
{
  internal sealed class GameInviteTaskNoResult
  {
    public string SessionId { get; set; }

    [SecuritySafeCritical]
    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      ChooserHelper.LaunchUriChildTask(this.BuildUriString(), "");
    }

    private string BuildUriString()
    {
      HostInfo hostInfo = new HostInfo();
      return string.Format("xboxgames://invite?sessionId={0}&gameId={1}&productId={2}", (object) HttpUtility.UrlEncode(this.SessionId), (object) HttpUtility.UrlEncode(GameInviteTaskNoResult.NativeMethods.GF_GetCurrentGameId().ToString()), (object) HttpUtility.UrlEncode(hostInfo.ProductId));
    }

    private static class NativeMethods
    {
      [SecuritySafeCritical]
      [DllImport("zmf_client.dll")]
      public static extern uint GF_GetCurrentGameId();
    }
  }
}
