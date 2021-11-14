// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.NetworkException
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Net.NetworkInformation
{
  public sealed class NetworkException : SystemException
  {
    private NetworkError errorCode;

    public NetworkException(NetworkError error)
      : base(NetworkException.makeMessage(error))
    {
      this.errorCode = error;
    }

    public NetworkError NetworkErrorCode => this.errorCode;

    private static string makeMessage(NetworkError error)
    {
      switch (error)
      {
        case NetworkError.NetworkSelectionRequirementFailed:
          return LocalizeString.NetworkSelectionRequirementFailed;
        case NetworkError.NetworkSelectionPreferencesFailed:
          return LocalizeString.NetworkSelectionPreferencesFailed;
        case NetworkError.NameResolutionNoHostAddresses:
          return LocalizeString.NameResolutionNoHostAddresses;
        case NetworkError.NetworkNotificationRegistrationFailed:
          return LocalizeString.NetworkNotificationRegistrationFailed;
        case NetworkError.SocketAlreadyBound:
          return LocalizeString.SocketAlreadyBound;
        case NetworkError.SocketNotConnected:
          return LocalizeString.SocketNotConnected;
        case NetworkError.NetworkOperationFailedError:
          return LocalizeString.NetworkOperationFailedError;
        case NetworkError.WebRequestAlreadyFinished:
          return LocalizeString.WebRequestAlreadyFinished;
        case NetworkError.NameResolutionOperationAborted:
          return LocalizeString.NameResolutionOperationAborted;
        default:
          return LocalizeString.NetworkOperationFailedError;
      }
    }
  }
}
