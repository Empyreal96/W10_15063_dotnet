// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomViewChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1205846120, 46441, 19225, 132, 45, 142, 108, 249, 9, 137, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SemanticZoomViewChangedEventArgs))]
  [WebHostHidden]
  internal interface ISemanticZoomViewChangedEventArgs
  {
    bool IsSourceZoomedInView { get; set; }

    SemanticZoomLocation SourceItem { get; set; }

    SemanticZoomLocation DestinationItem { get; set; }
  }
}
