// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IIconElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2599452731, 53324, 18042, 187, 213, 155, 129, 240, 45, 154, 86)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (IconElement))]
  [WebHostHidden]
  internal interface IIconElement
  {
    Brush Foreground { get; set; }
  }
}
