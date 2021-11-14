// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRacingWheelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RacingWheel))]
  [Guid(985738453, 22555, 18742, 159, 148, 105, 241, 230, 81, 76, 125)]
  internal interface IRacingWheelStatics
  {
    event EventHandler<RacingWheel> RacingWheelAdded;

    event EventHandler<RacingWheel> RacingWheelRemoved;

    IVectorView<RacingWheel> RacingWheels { get; }
  }
}
