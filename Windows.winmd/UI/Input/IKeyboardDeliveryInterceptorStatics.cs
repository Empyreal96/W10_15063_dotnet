// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IKeyboardDeliveryInterceptorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (KeyboardDeliveryInterceptor))]
  [Guid(4193663906, 52922, 18261, 138, 126, 20, 192, 255, 236, 210, 57)]
  internal interface IKeyboardDeliveryInterceptorStatics
  {
    KeyboardDeliveryInterceptor GetForCurrentView();
  }
}
