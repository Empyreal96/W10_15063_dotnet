// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRacingWheelStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(3865492650, 60925, 17187, 169, 246, 60, 56, 64, 72, 209, 237)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RacingWheel))]
  internal interface IRacingWheelStatics2 : IRacingWheelStatics
  {
    RacingWheel FromGameController(IGameController gameController);
  }
}
