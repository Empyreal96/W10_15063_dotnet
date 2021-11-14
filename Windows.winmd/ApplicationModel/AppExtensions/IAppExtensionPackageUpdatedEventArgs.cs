// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionPackageUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppExtensionPackageUpdatedEventArgs))]
  [Guid(981713983, 31102, 17589, 186, 36, 164, 200, 181, 165, 67, 215)]
  internal interface IAppExtensionPackageUpdatedEventArgs
  {
    string AppExtensionName { get; }

    Package Package { get; }

    IVectorView<AppExtension> Extensions { get; }
  }
}
