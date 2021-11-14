// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePairingResultStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DevicePairingResultStatus
  {
    Paired,
    NotReadyToPair,
    NotPaired,
    AlreadyPaired,
    ConnectionRejected,
    TooManyConnections,
    HardwareFailure,
    AuthenticationTimeout,
    AuthenticationNotAllowed,
    AuthenticationFailure,
    NoSupportedProfiles,
    ProtectionLevelCouldNotBeMet,
    AccessDenied,
    InvalidCeremonyData,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] PairingCanceled,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] OperationAlreadyInProgress,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] RequiredHandlerNotRegistered,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] RejectedByHandler,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] RemoteDeviceHasAssociation,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] Failed,
  }
}
