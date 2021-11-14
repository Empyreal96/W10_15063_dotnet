// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3612445405, 48757, 16419, 141, 235, 198, 81, 60, 49, 146, 163)]
  [ExclusiveTo(typeof (Pivot))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPivotStatics2
  {
    DependencyProperty LeftHeaderProperty { get; }

    DependencyProperty LeftHeaderTemplateProperty { get; }

    DependencyProperty RightHeaderProperty { get; }

    DependencyProperty RightHeaderTemplateProperty { get; }
  }
}
