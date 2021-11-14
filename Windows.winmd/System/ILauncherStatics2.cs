// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [Guid(1505374139, 9419, 19458, 164, 196, 130, 148, 86, 157, 84, 241)]
  [ExclusiveTo(typeof (Launcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILauncherStatics2
  {
    [Overload("LaunchUriForResultsAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriWithDataAsync")]
    IAsyncOperation<bool> LaunchUriAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("QueryUriSupportAsync")]
    [RemoteAsync]
    IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType);

    [RemoteAsync]
    [Overload("QueryUriSupportWithPackageFamilyNameAsync")]
    IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType,
      string packageFamilyName);

    [Overload("QueryFileSupportAsync")]
    [RemoteAsync]
    IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file);

    [Overload("QueryFileSupportWithPackageFamilyNameAsync")]
    [RemoteAsync]
    IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file,
      string packageFamilyName);

    [RemoteAsync]
    [Overload("FindUriSchemeHandlersAsync")]
    IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme);

    [Overload("FindUriSchemeHandlersWithLaunchUriTypeAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme,
      LaunchQuerySupportType launchQuerySupportType);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindFileHandlersAsync(
      string extension);
  }
}
