// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1830284997, 8115, 19595, 170, 35, 245, 225, 93, 106, 182, 78)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBoxStatics3
  {
    DependencyProperty DesiredCandidateWindowAlignmentProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }
  }
}
