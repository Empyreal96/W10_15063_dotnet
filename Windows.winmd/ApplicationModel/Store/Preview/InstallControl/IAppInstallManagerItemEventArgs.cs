// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManagerItemEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(3159381827, 18036, 19921, 149, 126, 194, 86, 130, 8, 106, 20)]
  [ExclusiveTo(typeof (AppInstallManagerItemEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppInstallManagerItemEventArgs
  {
    AppInstallItem Item { get; }
  }
}
