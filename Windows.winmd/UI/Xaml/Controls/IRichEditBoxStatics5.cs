// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1264338280, 17365, 17382, 187, 185, 203, 78, 98, 80, 244, 90)]
  [ExclusiveTo(typeof (RichEditBox))]
  [WebHostHidden]
  internal interface IRichEditBoxStatics5
  {
    DependencyProperty SelectionHighlightColorWhenNotFocusedProperty { get; }

    DependencyProperty MaxLengthProperty { get; }
  }
}
