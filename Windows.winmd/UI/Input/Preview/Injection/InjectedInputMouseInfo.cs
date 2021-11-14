// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo
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
  public sealed class InjectedInputMouseInfo : IInjectedInputMouseInfo
  {
    [MethodImpl]
    public extern InjectedInputMouseInfo();

    public extern InjectedInputMouseOptions MouseOptions { [MethodImpl] get; [MethodImpl] set; }

    public extern uint MouseData { [MethodImpl] get; [MethodImpl] set; }

    public extern int DeltaY { [MethodImpl] get; [MethodImpl] set; }

    public extern int DeltaX { [MethodImpl] get; [MethodImpl] set; }

    public extern uint TimeOffsetInMilliseconds { [MethodImpl] get; [MethodImpl] set; }
  }
}
