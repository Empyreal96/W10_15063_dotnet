// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputTouchInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Guid(575656415, 17384, 24309, 81, 10, 105, 202, 140, 155, 76, 40)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InjectedInputTouchInfo))]
  internal interface IInjectedInputTouchInfo
  {
    InjectedInputRectangle Contact { get; set; }

    int Orientation { get; set; }

    InjectedInputPointerInfo PointerInfo { get; set; }

    double Pressure { get; set; }

    InjectedInputTouchParameters TouchParameters { get; set; }
  }
}
