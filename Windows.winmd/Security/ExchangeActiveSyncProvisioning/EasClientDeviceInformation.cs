// Decompiled with JetBrains decompiler
// Type: Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.ExchangeActiveSyncProvisioning
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EasClientDeviceInformation : 
    IEasClientDeviceInformation,
    IEasClientDeviceInformation2
  {
    [MethodImpl]
    public extern EasClientDeviceInformation();

    public extern Guid Id { [MethodImpl] get; }

    public extern string OperatingSystem { [MethodImpl] get; }

    public extern string FriendlyName { [MethodImpl] get; }

    public extern string SystemManufacturer { [MethodImpl] get; }

    public extern string SystemProductName { [MethodImpl] get; }

    public extern string SystemSku { [MethodImpl] get; }

    public extern string SystemHardwareVersion { [MethodImpl] get; }

    public extern string SystemFirmwareVersion { [MethodImpl] get; }
  }
}
