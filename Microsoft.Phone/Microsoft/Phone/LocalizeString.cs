// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.LocalizeString
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Phone
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class LocalizeString
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal LocalizeString()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (LocalizeString.resourceMan == null)
          LocalizeString.resourceMan = new ResourceManager("Microsoft.Phone.LocalizeString", typeof (LocalizeString).Assembly);
        return LocalizeString.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => LocalizeString.resourceCulture;
      set => LocalizeString.resourceCulture = value;
    }

    internal static string PushErrorTypeChannelOpenFailed => LocalizeString.ResourceManager.GetString(nameof (PushErrorTypeChannelOpenFailed), LocalizeString.resourceCulture);

    internal static string PushErrorTypeMessageBadContent => LocalizeString.ResourceManager.GetString(nameof (PushErrorTypeMessageBadContent), LocalizeString.resourceCulture);

    internal static string PushErrorTypeNotificationRateTooHigh => LocalizeString.ResourceManager.GetString(nameof (PushErrorTypeNotificationRateTooHigh), LocalizeString.resourceCulture);

    internal static string PushErrorTypePayloadFormatInvalid => LocalizeString.ResourceManager.GetString(nameof (PushErrorTypePayloadFormatInvalid), LocalizeString.resourceCulture);

    internal static string PushErrorTypePowerLevelChanged => LocalizeString.ResourceManager.GetString(nameof (PushErrorTypePowerLevelChanged), LocalizeString.resourceCulture);

    internal static string PushErrorTypeUnknown => LocalizeString.ResourceManager.GetString(nameof (PushErrorTypeUnknown), LocalizeString.resourceCulture);

    internal static string PushNotificationTileUriBindFailed => LocalizeString.ResourceManager.GetString(nameof (PushNotificationTileUriBindFailed), LocalizeString.resourceCulture);

    internal static string PushNotificationChannelBindFailed => LocalizeString.ResourceManager.GetString(nameof (PushNotificationChannelBindFailed), LocalizeString.resourceCulture);

    internal static string PushNotificationChannelBindingExists => LocalizeString.ResourceManager.GetString(nameof (PushNotificationChannelBindingExists), LocalizeString.resourceCulture);

    internal static string PushNotificationChannelExists => LocalizeString.ResourceManager.GetString(nameof (PushNotificationChannelExists), LocalizeString.resourceCulture);

    internal static string PushNotificationChannelNotOpened => LocalizeString.ResourceManager.GetString(nameof (PushNotificationChannelNotOpened), LocalizeString.resourceCulture);

    internal static string PushNotificationChannelOpenFailed => LocalizeString.ResourceManager.GetString(nameof (PushNotificationChannelOpenFailed), LocalizeString.resourceCulture);

    internal static string PushNotificationChannelQuotaExceeded => LocalizeString.ResourceManager.GetString(nameof (PushNotificationChannelQuotaExceeded), LocalizeString.resourceCulture);

    internal static string PushNotificationChannelServerUnavailable => LocalizeString.ResourceManager.GetString(nameof (PushNotificationChannelServerUnavailable), LocalizeString.resourceCulture);

    internal static string ShellInvalidInterval => LocalizeString.ResourceManager.GetString(nameof (ShellInvalidInterval), LocalizeString.resourceCulture);

    internal static string ShellInvalidRemoteImageUri => LocalizeString.ResourceManager.GetString(nameof (ShellInvalidRemoteImageUri), LocalizeString.resourceCulture);

    internal static string ShellTileTemplateMismatch => LocalizeString.ResourceManager.GetString(nameof (ShellTileTemplateMismatch), LocalizeString.resourceCulture);

    internal static string ShellInvalidUri => LocalizeString.ResourceManager.GetString(nameof (ShellInvalidUri), LocalizeString.resourceCulture);

    internal static string CreateTileRestricted => LocalizeString.ResourceManager.GetString(nameof (CreateTileRestricted), LocalizeString.resourceCulture);

    internal static string NetworkSelectionRequirementFailed => LocalizeString.ResourceManager.GetString(nameof (NetworkSelectionRequirementFailed), LocalizeString.resourceCulture);

    internal static string NetworkSelectionPreferencesFailed => LocalizeString.ResourceManager.GetString(nameof (NetworkSelectionPreferencesFailed), LocalizeString.resourceCulture);

    internal static string NetworkNotificationRegistrationFailed => LocalizeString.ResourceManager.GetString(nameof (NetworkNotificationRegistrationFailed), LocalizeString.resourceCulture);

    internal static string NameResolutionNoHostAddresses => LocalizeString.ResourceManager.GetString(nameof (NameResolutionNoHostAddresses), LocalizeString.resourceCulture);

    internal static string SocketAlreadyBound => LocalizeString.ResourceManager.GetString(nameof (SocketAlreadyBound), LocalizeString.resourceCulture);

    internal static string SocketNotConnected => LocalizeString.ResourceManager.GetString(nameof (SocketNotConnected), LocalizeString.resourceCulture);

    internal static string NetworkOperationFailedError => LocalizeString.ResourceManager.GetString(nameof (NetworkOperationFailedError), LocalizeString.resourceCulture);

    internal static string InvalidNetworkInterfaceError => LocalizeString.ResourceManager.GetString(nameof (InvalidNetworkInterfaceError), LocalizeString.resourceCulture);

    internal static string NameResolutionOperationAborted => LocalizeString.ResourceManager.GetString(nameof (NameResolutionOperationAborted), LocalizeString.resourceCulture);

    internal static string InvalidWebBrowserSourceUrl => LocalizeString.ResourceManager.GetString(nameof (InvalidWebBrowserSourceUrl), LocalizeString.resourceCulture);

    internal static string WebRequestAlreadyFinished => LocalizeString.ResourceManager.GetString(nameof (WebRequestAlreadyFinished), LocalizeString.resourceCulture);

    internal static string CellularConnectionNotAllowed => LocalizeString.ResourceManager.GetString(nameof (CellularConnectionNotAllowed), LocalizeString.resourceCulture);
  }
}
