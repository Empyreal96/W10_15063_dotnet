// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputTouchInfo
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
  public sealed class InjectedInputTouchInfo : IInjectedInputTouchInfo
  {
    [MethodImpl]
    public extern InjectedInputTouchInfo();

    public extern InjectedInputRectangle Contact { [MethodImpl] get; [MethodImpl] set; }

    public extern int Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern InjectedInputPointerInfo PointerInfo { [MethodImpl] get; [MethodImpl] set; }

    public extern double Pressure { [MethodImpl] get; [MethodImpl] set; }

    public extern InjectedInputTouchParameters TouchParameters { [MethodImpl] get; [MethodImpl] set; }
  }
}
