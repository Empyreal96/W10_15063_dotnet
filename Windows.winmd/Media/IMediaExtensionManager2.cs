// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaExtensionManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1540276039, 16451, 20461, 172, 175, 84, 236, 41, 223, 177, 247)]
  [ExclusiveTo(typeof (MediaExtensionManager))]
  internal interface IMediaExtensionManager2 : IMediaExtensionManager
  {
    void RegisterMediaExtensionForAppService(
      IMediaExtension extension,
      AppServiceConnection connection);
  }
}
