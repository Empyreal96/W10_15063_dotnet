// Decompiled with JetBrains decompiler
// Type: Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.ExchangeActiveSyncProvisioning
{
  [Guid(4289943843, 47910, 19818, 129, 188, 22, 90, 238, 10, 215, 84)]
  [ExclusiveTo(typeof (EasClientDeviceInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEasClientDeviceInformation2 : IEasClientDeviceInformation
  {
    string SystemHardwareVersion { get; }

    string SystemFirmwareVersion { get; }
  }
}
