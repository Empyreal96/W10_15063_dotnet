// Decompiled with JetBrains decompiler
// Type: Windows.Embedded.DeviceLockdown.IDeviceLockdownProfileInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Embedded.DeviceLockdown
{
  [ExclusiveTo(typeof (DeviceLockdownProfileInformation))]
  [ContractVersion(typeof (DeviceLockdownContract), 65536)]
  [Guid(2038489422, 17841, 19094, 146, 252, 98, 117, 107, 115, 150, 120)]
  internal interface IDeviceLockdownProfileInformation
  {
    string Name { get; }
  }
}
