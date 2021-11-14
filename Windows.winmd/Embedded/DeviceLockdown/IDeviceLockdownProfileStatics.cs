// Decompiled with JetBrains decompiler
// Type: Windows.Embedded.DeviceLockdown.IDeviceLockdownProfileStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Embedded.DeviceLockdown
{
  [ExclusiveTo(typeof (DeviceLockdownProfile))]
  [ContractVersion(typeof (DeviceLockdownContract), 65536)]
  [Guid(1647274341, 63912, 16801, 166, 145, 136, 205, 128, 199, 160, 105)]
  internal interface IDeviceLockdownProfileStatics
  {
    IVectorView<Guid> GetSupportedLockdownProfiles();

    Guid GetCurrentLockdownProfile();

    IAsyncAction ApplyLockdownProfileAsync(Guid profileID);

    DeviceLockdownProfileInformation GetLockdownProfileInformation(
      Guid profileID);
  }
}
