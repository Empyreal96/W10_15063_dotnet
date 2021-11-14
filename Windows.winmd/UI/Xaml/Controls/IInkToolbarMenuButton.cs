// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarMenuButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbarMenuButton))]
  [Guid(2249116389, 30259, 20129, 162, 9, 80, 57, 45, 26, 235, 209)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkToolbarMenuButton
  {
    InkToolbarMenuKind MenuKind { get; }

    bool IsExtensionGlyphShown { get; set; }
  }
}
