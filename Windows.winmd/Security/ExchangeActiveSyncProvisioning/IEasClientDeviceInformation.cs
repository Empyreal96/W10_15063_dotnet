// Decompiled with JetBrains decompiler
// Type: Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.ExchangeActiveSyncProvisioning
{
  [ExclusiveTo(typeof (EasClientDeviceInformation))]
  [Guid(1423956353, 6504, 19619, 185, 88, 229, 149, 209, 101, 5, 235)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEasClientDeviceInformation
  {
    Guid Id { get; }

    string OperatingSystem { get; }

    string FriendlyName { get; }

    string SystemManufacturer { get; }

    string SystemProductName { get; }

    string SystemSku { get; }
  }
}
