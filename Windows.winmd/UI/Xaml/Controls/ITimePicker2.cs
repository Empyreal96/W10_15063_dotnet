// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePicker2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TimePicker))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(267417996, 63778, 16799, 139, 61, 35, 238, 117, 134, 212, 142)]
  [WebHostHidden]
  internal interface ITimePicker2
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
