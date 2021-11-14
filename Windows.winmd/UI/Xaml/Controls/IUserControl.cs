// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IUserControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (UserControl))]
  [Guid(2812714697, 59957, 18041, 191, 41, 244, 240, 146, 134, 211, 20)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUserControl
  {
    UIElement Content { get; set; }
  }
}
