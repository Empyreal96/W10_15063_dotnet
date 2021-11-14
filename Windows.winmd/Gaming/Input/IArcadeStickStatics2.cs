// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IArcadeStickStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1387648836, 48006, 17498, 181, 156, 89, 111, 14, 42, 73, 223)]
  [ExclusiveTo(typeof (ArcadeStick))]
  internal interface IArcadeStickStatics2 : IArcadeStickStatics
  {
    ArcadeStick FromGameController(IGameController gameController);
  }
}
