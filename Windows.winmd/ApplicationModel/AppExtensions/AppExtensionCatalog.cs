// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.AppExtensionCatalog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IAppExtensionCatalogStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppExtensionCatalog : IAppExtensionCatalog
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppExtension>> FindAllAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestRemovePackageAsync(
      string packageFullName);

    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageInstalledEventArgs> PackageInstalled;

    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatingEventArgs> PackageUpdating;

    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatedEventArgs> PackageUpdated;

    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUninstallingEventArgs> PackageUninstalling;

    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageStatusChangedEventArgs> PackageStatusChanged;

    [MethodImpl]
    public static extern AppExtensionCatalog Open(string appExtensionName);
  }
}
