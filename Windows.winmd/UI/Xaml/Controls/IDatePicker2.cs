// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePicker2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3140007029, 11295, 17216, 158, 48, 148, 143, 153, 201, 229, 122)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (DatePicker))]
  [WebHostHidden]
  internal interface IDatePicker2
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
