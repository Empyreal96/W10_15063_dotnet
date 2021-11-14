// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.QuirksMode
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System.Runtime.InteropServices;

namespace Microsoft.Phone
{
  internal class QuirksMode
  {
    private static bool shouldUseBottomLetterbox;
    private static bool checkedUserManagedNavBarEnabled;

    internal static bool ShouldAllowGameExitInNonXnaApps() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldIgnoreAdMobExceptionFromScriptNotify() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldDecodeJpegWithBothHeightAndWidth() => QuirksMode.CheckMinVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldNotAllowBackgroundNavigation() => QuirksMode.CheckMinVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldCallOnNavigatingFromPageForExternalNavigations() => QuirksMode.CheckMinVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldForceTextBindings() => QuirksMode.CheckMinVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldSimulate7Accelerometer() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldThrowIfDisposedOnSensorStop() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldNotSetPhotoResultErrorCode() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldNotIgnoreEventsFromBackgroundPages() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldPhysicalKeyboardUndeployClearFocusFromTextOrPasswordBox() => QuirksMode.CheckMinVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldGuideDialogSuspendWhileAppIsInactive() => QuirksMode.CheckMinVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldPictureDateDoubleCorrectForLocalTime() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldUseGlobalUiOrientationInsteadOfPageOrientation() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldAllowStartupModeLaunchWhenActivated() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldWebBrowserBlockRoutedEventsFromBubblingToParent() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldFixSoftwareLoopbackInterfaceName() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldAllowANID() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldAllowANID2() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldAllowPlayStateChangedEventArgs() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldXnaUseMangoDisplaySize() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldXnaUnDisposeStream() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldUseWeakDecodingForWebBrowserTask() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldApplyScaleFactorToWebBrowserControlContent() => true;

    internal static bool ShouldTranscodePhotosToJpg() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldReportLTENetworkType() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldCoverMargin() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldPhotoStreamOpenWithDeleteOnCloseFlag() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldThrowOnMultiplePhoneApplicationFramesCreated() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldPhotoResultRemoveDriveLetterFromFilename() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldPanoramaCallMeasureForCollapsedItems() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_1);

    internal static bool ShouldPanoramaSelectOnlyValidItems() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_1);

    internal static bool ShouldAllowForwardNavigateOnRehydration() => QuirksMode.CheckMinVersion(AppPlatformVersions.V8_1);

    internal static bool ShouldUseLegacyChromeHeights() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldMapsUseDefaultCredentials() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldSupportDirectRendering() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldUseBottomLetterboxForUserManagedNavBar()
    {
      if (!QuirksMode.checkedUserManagedNavBarEnabled)
      {
        QuirksMode.shouldUseBottomLetterbox = QuirksMode.IsUserManagedNavBarEnabled() && QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);
        QuirksMode.checkedUserManagedNavBarEnabled = true;
      }
      return QuirksMode.shouldUseBottomLetterbox;
    }

    [DllImport("PlatformInterop.dll")]
    internal static extern bool IsUserManagedNavBarEnabled();

    internal static bool ShouldEnforceId_Cap_PhoneDialer() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V8_0);

    internal static bool ShouldUserExtendedPropertiesTryGetValueAlwaysReturnTrue() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldUseQuirkMax7_0() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_0);

    internal static bool ShouldUseQuirkMax7_1() => QuirksMode.CheckMaxVersion(AppPlatformVersions.V7_1);

    internal static bool ShouldUseQuirkMin7_1() => QuirksMode.CheckMinVersion(AppPlatformVersions.V7_1);

    private static uint TargetMajorVersionNumber { get; set; }

    private static uint TargetMinorVersionNumber { get; set; }

    static QuirksMode()
    {
      HostInfo hostInfo = new HostInfo();
      QuirksMode.TargetMajorVersionNumber = hostInfo.AppTargetRuntimeMajorVersion;
      QuirksMode.TargetMinorVersionNumber = hostInfo.AppTargetRuntimeMinorVersion;
    }

    private static bool CheckMaxVersion(AppPlatformVersion maxVersion) => (long) QuirksMode.TargetMajorVersionNumber < (long) maxVersion.MajorNumber || (long) QuirksMode.TargetMajorVersionNumber == (long) maxVersion.MajorNumber && (long) QuirksMode.TargetMinorVersionNumber <= (long) maxVersion.MinorNumber;

    private static bool CheckMinVersion(AppPlatformVersion minVersion) => (long) QuirksMode.TargetMajorVersionNumber > (long) minVersion.MajorNumber || (long) QuirksMode.TargetMajorVersionNumber == (long) minVersion.MajorNumber && (long) QuirksMode.TargetMinorVersionNumber >= (long) minVersion.MinorNumber;
  }
}
