// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketErrorStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketErrorStatus
  {
    Unknown,
    OperationAborted,
    HttpInvalidServerResponse,
    ConnectionTimedOut,
    AddressFamilyNotSupported,
    SocketTypeNotSupported,
    HostNotFound,
    NoDataRecordOfRequestedType,
    NonAuthoritativeHostNotFound,
    ClassTypeNotFound,
    AddressAlreadyInUse,
    CannotAssignRequestedAddress,
    ConnectionRefused,
    NetworkIsUnreachable,
    UnreachableHost,
    NetworkIsDown,
    NetworkDroppedConnectionOnReset,
    SoftwareCausedConnectionAbort,
    ConnectionResetByPeer,
    HostIsDown,
    NoAddressesFound,
    TooManyOpenFiles,
    MessageTooLong,
    CertificateExpired,
    CertificateUntrustedRoot,
    CertificateCommonNameIsIncorrect,
    CertificateWrongUsage,
    CertificateRevoked,
    CertificateNoRevocationCheck,
    CertificateRevocationServerOffline,
    CertificateIsInvalid,
  }
}
