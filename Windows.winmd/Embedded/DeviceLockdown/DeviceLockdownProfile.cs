// Decompiled with JetBrains decompiler
// Type: Windows.Embedded.DeviceLockdown.DeviceLockdownProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Embedded.DeviceLockdown
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDeviceLockdownProfileStatics), 65536, "Windows.Embedded.DeviceLockdown.DeviceLockdownContract")]
  [ContractVersion(typeof (DeviceLockdownContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class DeviceLockdownProfile
  {
    [MethodImpl]
    public static extern IVectorView<Guid> GetSupportedLockdownProfiles();

    [MethodImpl]
    public static extern Guid GetCurrentLockdownProfile();

    [MethodImpl]
    public static extern IAsyncAction ApplyLockdownProfileAsync(Guid profileID);

    [MethodImpl]
    public static extern DeviceLockdownProfileInformation GetLockdownProfileInformation(
      Guid profileID);
  }
}
