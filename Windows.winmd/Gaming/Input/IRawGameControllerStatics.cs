// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRawGameControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (RawGameController))]
  [Guid(3951888274, 59738, 19225, 175, 199, 10, 89, 248, 191, 117, 158)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRawGameControllerStatics
  {
    event EventHandler<RawGameController> RawGameControllerAdded;

    event EventHandler<RawGameController> RawGameControllerRemoved;

    IVectorView<RawGameController> RawGameControllers { get; }

    RawGameController FromGameController(IGameController gameController);
  }
}
