// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRangeBaseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (RangeBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1743722465, 65079, 18255, 158, 151, 59, 94, 11, 48, 242, 224)]
  internal interface IRangeBaseStatics
  {
    DependencyProperty MinimumProperty { get; }

    DependencyProperty MaximumProperty { get; }

    DependencyProperty SmallChangeProperty { get; }

    DependencyProperty LargeChangeProperty { get; }

    DependencyProperty ValueProperty { get; }
  }
}
