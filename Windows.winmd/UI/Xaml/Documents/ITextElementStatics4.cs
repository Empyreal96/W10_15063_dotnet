// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElementStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4254032926, 27410, 16597, 182, 239, 209, 189, 18, 172, 144, 102)]
  [ExclusiveTo(typeof (TextElement))]
  internal interface ITextElementStatics4
  {
    DependencyProperty TextDecorationsProperty { get; }

    DependencyProperty IsAccessKeyScopeProperty { get; }

    DependencyProperty AccessKeyScopeOwnerProperty { get; }

    DependencyProperty KeyTipPlacementModeProperty { get; }

    DependencyProperty KeyTipHorizontalOffsetProperty { get; }

    DependencyProperty KeyTipVerticalOffsetProperty { get; }
  }
}
