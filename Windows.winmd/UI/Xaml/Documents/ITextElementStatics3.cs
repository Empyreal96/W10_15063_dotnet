// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElementStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TextElement))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3488599983, 4001, 17900, 154, 78, 155, 51, 102, 77, 200, 177)]
  internal interface ITextElementStatics3
  {
    DependencyProperty AllowFocusOnInteractionProperty { get; }

    DependencyProperty AccessKeyProperty { get; }

    DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; }
  }
}
