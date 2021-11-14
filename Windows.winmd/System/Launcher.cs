// Decompiled with JetBrains decompiler
// Type: Windows.System.Launcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [Static(typeof (ILauncherStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (ILauncherStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ILauncherStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ILauncherStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class Launcher
  {
    [Overload("QueryAppUriSupportAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri);

    [Overload("QueryAppUriSupportWithPackageFamilyNameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri,
      string packageFamilyName);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindAppUriHandlersAsync(
      Uri uri);

    [Overload("LaunchUriForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri);

    [Overload("LaunchUriWithOptionsForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriWithDataForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriForResultsForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchFolderAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderAsync(
      IStorageFolder folder);

    [Overload("LaunchFolderWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFolderAsync(
      IStorageFolder folder,
      FolderLauncherOptions options);

    [Overload("LaunchUriForResultsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriWithDataAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchUriAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [RemoteAsync]
    [Overload("QueryUriSupportAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType);

    [RemoteAsync]
    [Overload("QueryUriSupportWithPackageFamilyNameAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType,
      string packageFamilyName);

    [Overload("QueryFileSupportAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file);

    [RemoteAsync]
    [Overload("QueryFileSupportWithPackageFamilyNameAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file,
      string packageFamilyName);

    [RemoteAsync]
    [Overload("FindUriSchemeHandlersAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme);

    [Overload("FindUriSchemeHandlersWithLaunchUriTypeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme,
      LaunchQuerySupportType launchQuerySupportType);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AppInfo>> FindFileHandlersAsync(
      string extension);

    [Overload("LaunchFileAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFileAsync(IStorageFile file);

    [Overload("LaunchFileWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchFileAsync(
      IStorageFile file,
      LauncherOptions options);

    [Overload("LaunchUriAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchUriAsync(Uri uri);

    [Overload("LaunchUriWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> LaunchUriAsync(
      Uri uri,
      LauncherOptions options);
  }
}
