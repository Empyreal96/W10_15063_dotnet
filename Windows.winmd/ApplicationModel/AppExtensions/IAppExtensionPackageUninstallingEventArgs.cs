// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionPackageUninstallingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppExtensionPackageUninstallingEventArgs))]
  [Guid(1626431685, 5918, 16639, 174, 152, 171, 44, 32, 221, 77, 117)]
  internal interface IAppExtensionPackageUninstallingEventArgs
  {
    string AppExtensionName { get; }

    Package Package { get; }
  }
}
