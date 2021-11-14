// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Launcher))]
  [Guid(661737923, 40510, 17142, 145, 164, 93, 253, 235, 35, 36, 81)]
  internal interface ILauncherStatics
  {
    [Overload("LaunchFileAsync")]
    IAsyncOperation<bool> LaunchFileAsync(IStorageFile file);

    [Overload("LaunchFileWithOptionsAsync")]
    IAsyncOperation<bool> LaunchFileAsync(IStorageFile file, LauncherOptions options);

    [Overload("LaunchUriAsync")]
    IAsyncOperation<bool> LaunchUriAsync(Uri uri);

    [Overload("LaunchUriWithOptionsAsync")]
    IAsyncOperation<bool> LaunchUriAsync(Uri uri, LauncherOptions options);
  }
}
