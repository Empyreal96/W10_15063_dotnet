// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.ErrorHandler
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class ErrorHandler
  {
    private const uint XONLINE_E_SESSION_INSUFFICIENT_PRIVILEGES = 2148880897;

    [SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes")]
    [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
    public static Exception GetExceptionFromResult(uint result)
    {
      if (result == 0U)
        return (Exception) null;
      switch ((KernelReturnCode) result)
      {
        case KernelReturnCode.TooManyPendingAsyncOperations:
          return (Exception) new InvalidOperationException(FrameworkResources.TooManyPendingAsyncOperations);
        case KernelReturnCode.BeginEndPairDoesNotMatch:
          return (Exception) new ArgumentException(FrameworkResources.IAsyncNotFromBegin);
        case KernelReturnCode.ProFeatureNotSupported:
          return (Exception) new NotSupportedException(FrameworkResources.ProFeatureNotSupported);
        case KernelReturnCode.ProfileNotSignedIn:
          return (Exception) new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
        case KernelReturnCode.ProfileNotPrivileged:
        case (KernelReturnCode) 2148880897:
          return (Exception) new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
        case KernelReturnCode.GuideAlreadyVisible:
          return (Exception) new GuideAlreadyVisibleException(FrameworkResources.GamerServicesGuideAlreadyVisible);
        case KernelReturnCode.SessionAlreadyExists:
          return (Exception) new InvalidOperationException(FrameworkResources.SessionAlreadyExists);
        case KernelReturnCode.StaleSearchResult:
          return (Exception) new InvalidOperationException(FrameworkResources.StaleSearchResult);
        case KernelReturnCode.NotInvited:
          return (Exception) new InvalidOperationException(FrameworkResources.NotInvited);
        case KernelReturnCode.InviteeNotSignedIn:
          return (Exception) new InvalidOperationException(FrameworkResources.InviteeNotSignedIn);
        case KernelReturnCode.TrialMode:
          return (Exception) new GamerPrivilegeException(FrameworkResources.TrialMode);
        case KernelReturnCode.NetworkNotAvailable:
          return (Exception) new NetworkNotAvailableException(FrameworkResources.NetworkNotAvailable);
        case KernelReturnCode.LIVEn400BadRequest:
          return (Exception) new NetworkException(FrameworkResources.LIVEn400BadRequest);
        case KernelReturnCode.LIVEn401Unauthorized:
          return (Exception) new NetworkException(FrameworkResources.LIVEn401Unauthorized);
        case KernelReturnCode.LIVEn500InternalServerError:
          return (Exception) new NetworkException(FrameworkResources.LIVEn500InternalServerError);
        case KernelReturnCode.LIVEn503ServiceUnavailable:
          return (Exception) new NetworkException(FrameworkResources.LIVEn503ServiceUnavailable);
        case KernelReturnCode.LIVEnTitleUpdateRequired:
          return (Exception) new GameUpdateRequiredException(FrameworkResources.LIVEnTitleUpdateRequired);
        case KernelReturnCode.LIVEnFlashUpdateRequired:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnFlashUpdateRequired);
        case KernelReturnCode.LIVEnNotSupportedTitle:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnNotSupportedTitle);
        case KernelReturnCode.LIVEnAccountBanned:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnAccountBanned);
        case KernelReturnCode.LIVEnAccountSuspended:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnAccountSuspended);
        case KernelReturnCode.LIVEnCountryNotSupported:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnCountryNotSupported);
        case KernelReturnCode.LIVEnGamertagChangeRequired:
          return (Exception) new NetworkNotAvailableException(FrameworkResources.LIVEnGamertagChangeRequired);
        case KernelReturnCode.LIVEnGamertagUpdateRequired:
          return (Exception) new NetworkNotAvailableException(FrameworkResources.LIVEnGamertagUpdateRequired);
        case KernelReturnCode.LIVEnXBLConnectionUnavailable:
          return (Exception) new NetworkNotAvailableException(FrameworkResources.LIVEnXBLConnectionUnavailable);
        case KernelReturnCode.LIVEnUnexpectedNetworkError:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnUnexpectedNetworkError);
        case KernelReturnCode.LIVEnServiceNotProvisioned:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnServiceNotProvisioned);
        case KernelReturnCode.LIVEnInvalidUser:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnInvalidUser);
        case KernelReturnCode.LIVEnTermsOfServiceNotAccepted:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnTermsOfServiceNotAccepted);
        case KernelReturnCode.LIVEnXBLNotEnabled:
          return (Exception) new InvalidOperationException(FrameworkResources.LIVEnXBLNotEnabled);
        default:
          return Helpers.GetExceptionFromResult(result);
      }
    }

    public static void ThrowExceptionFromResult(uint result)
    {
      if (result == 0U)
        return;
      switch ((KernelReturnCode) result)
      {
        case KernelReturnCode.TooManyPendingAsyncOperations:
          throw new InvalidOperationException(FrameworkResources.TooManyPendingAsyncOperations);
        case KernelReturnCode.BeginEndPairDoesNotMatch:
          throw new ArgumentException(FrameworkResources.IAsyncNotFromBegin);
        case KernelReturnCode.ProFeatureNotSupported:
          throw new NotSupportedException(FrameworkResources.ProFeatureNotSupported);
        case KernelReturnCode.ProfileNotSignedIn:
          throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
        case KernelReturnCode.ProfileNotPrivileged:
        case (KernelReturnCode) 2148880897:
          throw new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
        case KernelReturnCode.GuideAlreadyVisible:
          throw new GuideAlreadyVisibleException(FrameworkResources.GamerServicesGuideAlreadyVisible);
        case KernelReturnCode.SessionAlreadyExists:
          throw new InvalidOperationException(FrameworkResources.SessionAlreadyExists);
        case KernelReturnCode.StaleSearchResult:
          throw new InvalidOperationException(FrameworkResources.StaleSearchResult);
        case KernelReturnCode.NotInvited:
          throw new InvalidOperationException(FrameworkResources.NotInvited);
        case KernelReturnCode.InviteeNotSignedIn:
          throw new InvalidOperationException(FrameworkResources.InviteeNotSignedIn);
        case KernelReturnCode.TrialMode:
          throw new GamerPrivilegeException(FrameworkResources.TrialMode);
        case KernelReturnCode.NetworkNotAvailable:
          throw new NetworkNotAvailableException(FrameworkResources.NetworkNotAvailable);
        case KernelReturnCode.LIVEn400BadRequest:
          throw new NetworkException(FrameworkResources.LIVEn400BadRequest);
        case KernelReturnCode.LIVEn401Unauthorized:
          throw new NetworkException(FrameworkResources.LIVEn401Unauthorized);
        case KernelReturnCode.LIVEn500InternalServerError:
          throw new NetworkException(FrameworkResources.LIVEn500InternalServerError);
        case KernelReturnCode.LIVEn503ServiceUnavailable:
          throw new NetworkException(FrameworkResources.LIVEn503ServiceUnavailable);
        case KernelReturnCode.LIVEnTitleUpdateRequired:
          throw new GameUpdateRequiredException(FrameworkResources.LIVEnTitleUpdateRequired);
        case KernelReturnCode.LIVEnFlashUpdateRequired:
          throw new InvalidOperationException(FrameworkResources.LIVEnFlashUpdateRequired);
        case KernelReturnCode.LIVEnNotSupportedTitle:
          throw new InvalidOperationException(FrameworkResources.LIVEnNotSupportedTitle);
        case KernelReturnCode.LIVEnAccountBanned:
          throw new InvalidOperationException(FrameworkResources.LIVEnAccountBanned);
        case KernelReturnCode.LIVEnAccountSuspended:
          throw new InvalidOperationException(FrameworkResources.LIVEnAccountSuspended);
        case KernelReturnCode.LIVEnCountryNotSupported:
          throw new InvalidOperationException(FrameworkResources.LIVEnCountryNotSupported);
        case KernelReturnCode.LIVEnGamertagChangeRequired:
          throw new NetworkNotAvailableException(FrameworkResources.LIVEnGamertagChangeRequired);
        case KernelReturnCode.LIVEnGamertagUpdateRequired:
          throw new NetworkNotAvailableException(FrameworkResources.LIVEnGamertagUpdateRequired);
        case KernelReturnCode.LIVEnXBLConnectionUnavailable:
          throw new NetworkNotAvailableException(FrameworkResources.LIVEnXBLConnectionUnavailable);
        case KernelReturnCode.LIVEnUnexpectedNetworkError:
          throw new InvalidOperationException(FrameworkResources.LIVEnUnexpectedNetworkError);
        case KernelReturnCode.LIVEnServiceNotProvisioned:
          throw new InvalidOperationException(FrameworkResources.LIVEnServiceNotProvisioned);
        case KernelReturnCode.LIVEnInvalidUser:
          throw new InvalidOperationException(FrameworkResources.LIVEnInvalidUser);
        case KernelReturnCode.LIVEnTermsOfServiceNotAccepted:
          throw new InvalidOperationException(FrameworkResources.LIVEnTermsOfServiceNotAccepted);
        case KernelReturnCode.LIVEnXBLNotEnabled:
          throw new InvalidOperationException(FrameworkResources.LIVEnXBLNotEnabled);
        case KernelReturnCode.LIVEnNoXBLAccount:
          throw new InvalidOperationException(FrameworkResources.LIVEnNoXBLAccount);
        case KernelReturnCode.NetworkOperationTimedOut:
          throw new InvalidOperationException(FrameworkResources.NetworkOperationTimedOut, (Exception) new NetworkException(FrameworkResources.NetworkOperationTimedOut));
        default:
          Helpers.ThrowExceptionFromResult(result);
          break;
      }
    }
  }
}
