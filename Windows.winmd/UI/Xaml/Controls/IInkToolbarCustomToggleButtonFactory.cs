// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomToggleButtonFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1241528141, 19666, 20185, 134, 62, 131, 184, 207, 63, 210, 175)]
  [ExclusiveTo(typeof (InkToolbarCustomToggleButton))]
  internal interface IInkToolbarCustomToggleButtonFactory
  {
    InkToolbarCustomToggleButton CreateInstance(
      object outer,
      out object inner);
  }
}
