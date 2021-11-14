// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Resource
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
  internal class Resource
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resource()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Resource.resourceMan == null)
          Resource.resourceMan = new ResourceManager("Microsoft.Phone.Resource", typeof (Resource).Assembly);
        return Resource.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Resource.resourceCulture;
      set => Resource.resourceCulture = value;
    }

    internal static string CannotGoBack => Resource.ResourceManager.GetString(nameof (CannotGoBack), Resource.resourceCulture);

    internal static string CannotGoForward => Resource.ResourceManager.GetString(nameof (CannotGoForward), Resource.resourceCulture);

    internal static string Frame_CacheSizeMustBeGreaterThanOrEqualToZero => Resource.ResourceManager.GetString(nameof (Frame_CacheSizeMustBeGreaterThanOrEqualToZero), Resource.resourceCulture);

    internal static string Frame_DefaultContent => Resource.ResourceManager.GetString(nameof (Frame_DefaultContent), Resource.resourceCulture);

    internal static string NavigationService_ContentIsNotAUserControl => Resource.ResourceManager.GetString(nameof (NavigationService_ContentIsNotAUserControl), Resource.resourceCulture);

    internal static string NavigationService_FragmentNavigationRequiresContent => Resource.ResourceManager.GetString(nameof (NavigationService_FragmentNavigationRequiresContent), Resource.resourceCulture);

    internal static string NavigationService_JournalOwnership_UsesParentJournal_OnlyTopLevel => Resource.ResourceManager.GetString(nameof (NavigationService_JournalOwnership_UsesParentJournal_OnlyTopLevel), Resource.resourceCulture);

    internal static string NavigationService_NavigationToANullUriIsNotSupported => Resource.ResourceManager.GetString(nameof (NavigationService_NavigationToANullUriIsNotSupported), Resource.resourceCulture);

    internal static string NavigationService_UriNotNavigable => Resource.ResourceManager.GetString(nameof (NavigationService_UriNotNavigable), Resource.resourceCulture);

    internal static string PageResourceContentLoader_InvalidComponentSyntax => Resource.ResourceManager.GetString(nameof (PageResourceContentLoader_InvalidComponentSyntax), Resource.resourceCulture);

    internal static string PageResourceContentLoader_NoXAMLWasFound => Resource.ResourceManager.GetString(nameof (PageResourceContentLoader_NoXAMLWasFound), Resource.resourceCulture);

    internal static string PageResourceContentLoader_TheTypeSpecifiedInTheXClassCouldNotBeFound => Resource.ResourceManager.GetString(nameof (PageResourceContentLoader_TheTypeSpecifiedInTheXClassCouldNotBeFound), Resource.resourceCulture);

    internal static string PageResourceContentLoader_XAMLWasUnloadable => Resource.ResourceManager.GetString(nameof (PageResourceContentLoader_XAMLWasUnloadable), Resource.resourceCulture);

    internal static string UnderlyingPropertyIsReadOnly => Resource.ResourceManager.GetString(nameof (UnderlyingPropertyIsReadOnly), Resource.resourceCulture);

    internal static string UriMapper_MustNotHaveANullUriMappingCollection => Resource.ResourceManager.GetString(nameof (UriMapper_MustNotHaveANullUriMappingCollection), Resource.resourceCulture);

    internal static string UriMapping_MappedUriCannotBeOnlyFragment => Resource.ResourceManager.GetString(nameof (UriMapping_MappedUriCannotBeOnlyFragment), Resource.resourceCulture);

    internal static string UriMapping_MappedUriCannotBeOnlyQueryString => Resource.ResourceManager.GetString(nameof (UriMapping_MappedUriCannotBeOnlyQueryString), Resource.resourceCulture);

    internal static string UriMapping_TemplateMustBeSpecified => Resource.ResourceManager.GetString(nameof (UriMapping_TemplateMustBeSpecified), Resource.resourceCulture);

    internal static string UriMapping_UriTemplateCannotContainTheSameIdentifierMoreThanOnce => Resource.ResourceManager.GetString(nameof (UriMapping_UriTemplateCannotContainTheSameIdentifierMoreThanOnce), Resource.resourceCulture);

    internal static string UriMapping_UriTemplateCannotHaveAFragment => Resource.ResourceManager.GetString(nameof (UriMapping_UriTemplateCannotHaveAFragment), Resource.resourceCulture);

    internal static string UriMapping_UriTemplateCannotHaveAQueryString => Resource.ResourceManager.GetString(nameof (UriMapping_UriTemplateCannotHaveAQueryString), Resource.resourceCulture);

    internal static string NavigateWhileInBackground => Resource.ResourceManager.GetString(nameof (NavigateWhileInBackground), Resource.resourceCulture);
  }
}
