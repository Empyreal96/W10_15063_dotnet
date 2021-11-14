// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IArcadeStickStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(1547155656, 14257, 19160, 148, 88, 32, 15, 26, 48, 1, 142)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ArcadeStick))]
  internal interface IArcadeStickStatics
  {
    event EventHandler<ArcadeStick> ArcadeStickAdded;

    event EventHandler<ArcadeStick> ArcadeStickRemoved;

    IVectorView<ArcadeStick> ArcadeSticks { get; }
  }
}
