// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IKeyboardDeliveryInterceptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input
{
  [Guid(3032150120, 36681, 17516, 141, 181, 140, 15, 254, 133, 204, 158)]
  [ExclusiveTo(typeof (KeyboardDeliveryInterceptor))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IKeyboardDeliveryInterceptor
  {
    bool IsInterceptionEnabledWhenInForeground { get; set; }

    event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyDown;

    event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyUp;
  }
}
