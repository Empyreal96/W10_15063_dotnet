// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IBlockStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(4167732276, 36120, 19539, 174, 189, 145, 230, 16, 165, 224, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Block))]
  [WebHostHidden]
  internal interface IBlockStatics
  {
    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty MarginProperty { get; }
  }
}
