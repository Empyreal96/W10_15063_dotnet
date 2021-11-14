// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.DeviceManufacturers.ServiceAgentManager
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.DeviceManufacturers
{
  public static class ServiceAgentManager
  {
    private const int S_OK = 0;
    private const int E_ACCESSDENIED = -2147024891;

    [SecuritySafeCritical]
    public static void LaunchOnBootForTest()
    {
      switch (ServiceAgentManager.OtmLaunchOnBootForTest())
      {
        case -2147024891:
          throw new UnauthorizedAccessException("Only the service agents of an application that is being debugged can be restarted.");
        case 0:
          break;
        default:
          throw new InvalidOperationException("An unexpected error has occurred while trying to restart service agents.");
      }
    }

    [SecuritySafeCritical]
    public static void LaunchOnRestartAfterUpdateForTest()
    {
      switch (ServiceAgentManager.OtmLaunchOnRestartAfterUpdateForTest())
      {
        case -2147024891:
          throw new UnauthorizedAccessException("Only the service agents of an application that is being debugged can be restarted after update.");
        case 0:
          break;
        default:
          throw new InvalidOperationException("An unexpected error has occurred while trying to restart service agents after update.");
      }
    }

    [SecuritySafeCritical]
    public static void LaunchOnRestartAfterUnexpectedTerminationForTest()
    {
      switch (ServiceAgentManager.OtmLaunchOnRestartAfterUnexpectedTerminationForTest())
      {
        case -2147024891:
          throw new UnauthorizedAccessException("Only the service agents of an application that is being debugged can be restarted after crash.");
        case 0:
          break;
        default:
          throw new InvalidOperationException("An unexpected error has occurred while trying to restart service agents after crash.");
      }
    }

    [SecuritySafeCritical]
    [DllImport("EmClient.dll")]
    private static extern int OtmLaunchOnBootForTest();

    [SecuritySafeCritical]
    [DllImport("EmClient.dll")]
    private static extern int OtmLaunchOnRestartAfterUpdateForTest();

    [SecuritySafeCritical]
    [DllImport("EmClient.dll")]
    private static extern int OtmLaunchOnRestartAfterUnexpectedTerminationForTest();
  }
}
