// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseManagement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayReadyLicenseManagement))]
  [Guid(2867536193, 2391, 17413, 184, 146, 139, 243, 236, 93, 173, 217)]
  internal interface IPlayReadyLicenseManagement
  {
    [RemoteAsync]
    IAsyncAction DeleteLicenses(PlayReadyContentHeader contentHeader);
  }
}
