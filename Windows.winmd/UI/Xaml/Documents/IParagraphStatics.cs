// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IParagraphStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Paragraph))]
  [WebHostHidden]
  [Guid(4010313882, 21339, 20044, 141, 132, 40, 59, 51, 233, 138, 55)]
  internal interface IParagraphStatics
  {
    DependencyProperty TextIndentProperty { get; }
  }
}
