// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Networking.Voip.VoipBackgroundProcess
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Networking.Voip
{
  public static class VoipBackgroundProcess
  {
    private const int S_OK = 0;
    private const int E_ACCESSDENIED = -2147024891;
    private const int E_NOT_VALID_STATE = -2147019873;
    private const int E_EM_NOT_IN_FOREGROUND = -2147220720;

    [SecuritySafeCritical]
    public static void Launch()
    {
      int backgroundProcessId = 0;
      VoipBackgroundProcess.Launch(out backgroundProcessId);
    }

    [SecuritySafeCritical]
    public static void Launch(out int backgroundProcessId)
    {
      int num = VoipBackgroundProcess.VtmLaunchCommunicationAgent(out backgroundProcessId);
      switch (num)
      {
        case -2147220720:
        case -2147019873:
          throw new InvalidOperationException("The VoIP application's background process can only be launched by the UI process of a VoIP application that is in the foreground.");
        case -2147024891:
          throw new UnauthorizedAccessException("The background process can only be launched by applications which have the ID_CAP_VOIP capability defined in the manifest.");
        case 0:
          break;
        default:
          throw new InvalidOperationException("An unexpected error has occurred while launching the VoIP application's background process. HRESULT = " + (object) num);
      }
    }

    [SecuritySafeCritical]
    [DllImport("EmClient.dll")]
    private static extern int VtmLaunchCommunicationAgent(out int backgroundProcessId);
  }
}
