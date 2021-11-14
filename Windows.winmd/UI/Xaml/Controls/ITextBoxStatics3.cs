// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(235931072, 4277, 16630, 146, 194, 206, 19, 75, 13, 52, 87)]
  [ExclusiveTo(typeof (TextBox))]
  internal interface ITextBoxStatics3
  {
    DependencyProperty DesiredCandidateWindowAlignmentProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }
  }
}
