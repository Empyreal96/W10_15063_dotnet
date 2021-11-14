// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(3119284639, 46501, 16838, 179, 179, 221, 27, 49, 120, 188, 242)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (Launcher))]
  internal interface ILauncherStatics4
  {
    [Overload("QueryAppUriSupportAsync")]
    [RemoteAsync]
    IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("QueryAppUriSupportWithPackageFamilyNameAsync")]
    IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri,
      string packageFamilyName);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindAppUriHandlersAsync(
      Uri uri);

    [Overload("LaunchUriForUserAsync")]
    IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri);

    [Overload("LaunchUriWithOptionsForUserAsync")]
    IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriWithDataForUserAsync")]
    IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriForResultsForUserAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataForUserAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);
  }
}
