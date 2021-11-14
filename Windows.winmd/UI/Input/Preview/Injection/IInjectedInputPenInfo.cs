// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputPenInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InjectedInputPenInfo))]
  [Guid(1799400707, 51742, 21799, 126, 2, 40, 40, 84, 11, 177, 212)]
  internal interface IInjectedInputPenInfo
  {
    InjectedInputPointerInfo PointerInfo { get; set; }

    InjectedInputPenButtons PenButtons { get; set; }

    InjectedInputPenParameters PenParameters { get; set; }

    double Pressure { get; set; }

    double Rotation { get; set; }

    int TiltX { get; set; }

    int TiltY { get; set; }
  }
}
