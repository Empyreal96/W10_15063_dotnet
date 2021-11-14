// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPenInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class InjectedInputPenInfo : IInjectedInputPenInfo
  {
    [MethodImpl]
    public extern InjectedInputPenInfo();

    public extern InjectedInputPointerInfo PointerInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern InjectedInputPenButtons PenButtons { [MethodImpl] get; [MethodImpl] set; }

    public extern InjectedInputPenParameters PenParameters { [MethodImpl] get; [MethodImpl] set; }

    public extern double Pressure { [MethodImpl] get; [MethodImpl] set; }

    public extern double Rotation { [MethodImpl] get; [MethodImpl] set; }

    public extern int TiltX { [MethodImpl] get; [MethodImpl] set; }

    public extern int TiltY { [MethodImpl] get; [MethodImpl] set; }
  }
}
