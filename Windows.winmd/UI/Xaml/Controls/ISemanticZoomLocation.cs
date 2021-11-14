// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1107367734, 58306, 18795, 188, 78, 215, 80, 212, 55, 91, 154)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SemanticZoomLocation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISemanticZoomLocation
  {
    object Item { get; set; }

    Rect Bounds { get; set; }
  }
}
