// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionPackageInstalledEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [Guid(971346484, 13137, 19085, 151, 69, 231, 211, 221, 69, 188, 72)]
  [ExclusiveTo(typeof (AppExtensionPackageInstalledEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppExtensionPackageInstalledEventArgs
  {
    string AppExtensionName { get; }

    Package Package { get; }

    IVectorView<AppExtension> Extensions { get; }
  }
}
