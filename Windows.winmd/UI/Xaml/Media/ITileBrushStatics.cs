// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITileBrushStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (TileBrush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(882360923, 46434, 20072, 132, 53, 35, 153, 246, 235, 148, 213)]
  internal interface ITileBrushStatics
  {
    DependencyProperty AlignmentXProperty { get; }

    DependencyProperty AlignmentYProperty { get; }

    DependencyProperty StretchProperty { get; }
  }
}
