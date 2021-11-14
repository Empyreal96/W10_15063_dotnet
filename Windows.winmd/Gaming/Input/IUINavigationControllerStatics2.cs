// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IUINavigationControllerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(3771410659, 45579, 19211, 158, 212, 243, 213, 60, 236, 13, 228)]
  [ExclusiveTo(typeof (UINavigationController))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUINavigationControllerStatics2 : IUINavigationControllerStatics
  {
    UINavigationController FromGameController(IGameController gameController);
  }
}
