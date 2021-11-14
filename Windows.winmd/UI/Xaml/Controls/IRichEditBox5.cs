// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2792201450, 25489, 20283, 159, 211, 31, 208, 31, 73, 243, 39)]
  [ExclusiveTo(typeof (RichEditBox))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRichEditBox5
  {
    SolidColorBrush SelectionHighlightColorWhenNotFocused { get; set; }

    int MaxLength { get; set; }
  }
}
