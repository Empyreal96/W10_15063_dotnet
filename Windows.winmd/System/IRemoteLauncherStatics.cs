// Decompiled with JetBrains decompiler
// Type: Windows.System.IRemoteLauncherStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.System
{
  [ExclusiveTo(typeof (RemoteLauncher))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3621485203, 41740, 18615, 159, 33, 5, 16, 38, 164, 229, 23)]
  internal interface IRemoteLauncherStatics
  {
    [Overload("LaunchUriAsync")]
    IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri);

    [Overload("LaunchUriWithOptionsAsync")]
    IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri,
      RemoteLauncherOptions options);

    [Overload("LaunchUriWithDataAsync")]
    IAsyncOperation<RemoteLaunchUriStatus> LaunchUriAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest,
      Uri uri,
      RemoteLauncherOptions options,
      ValueSet inputData);
  }
}
