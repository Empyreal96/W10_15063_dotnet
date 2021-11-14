// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerFactoryManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [ExclusiveTo(typeof (GameControllerFactoryManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3939391044, 6623, 16661, 179, 42, 39, 147, 226, 174, 163, 187)]
  [WebHostHidden]
  internal interface IGameControllerFactoryManagerStatics2 : IGameControllerFactoryManagerStatics
  {
    IGameController TryGetFactoryControllerFromGameController(
      ICustomGameControllerFactory factory,
      IGameController gameController);
  }
}
