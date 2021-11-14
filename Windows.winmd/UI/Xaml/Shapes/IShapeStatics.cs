// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IShapeStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Shape))]
  [Guid(494619733, 40435, 18652, 145, 148, 157, 48, 111, 170, 96, 137)]
  internal interface IShapeStatics
  {
    DependencyProperty FillProperty { get; }

    DependencyProperty StrokeProperty { get; }

    DependencyProperty StrokeMiterLimitProperty { get; }

    DependencyProperty StrokeThicknessProperty { get; }

    DependencyProperty StrokeStartLineCapProperty { get; }

    DependencyProperty StrokeEndLineCapProperty { get; }

    DependencyProperty StrokeLineJoinProperty { get; }

    DependencyProperty StrokeDashOffsetProperty { get; }

    DependencyProperty StrokeDashCapProperty { get; }

    DependencyProperty StrokeDashArrayProperty { get; }

    DependencyProperty StretchProperty { get; }
  }
}
