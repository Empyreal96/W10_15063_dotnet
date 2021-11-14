// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.KeyboardDeliveryInterceptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IKeyboardDeliveryInterceptorStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class KeyboardDeliveryInterceptor : IKeyboardDeliveryInterceptor
  {
    public extern bool IsInterceptionEnabledWhenInForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyDown;

    public extern event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyUp;

    [MethodImpl]
    public static extern KeyboardDeliveryInterceptor GetForCurrentView();
  }
}
