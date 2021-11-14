// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDragOverThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(342883927, 15517, 16857, 165, 255, 141, 114, 57, 81, 104, 16)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DragOverThemeAnimation))]
  internal interface IDragOverThemeAnimationStatics
  {
    DependencyProperty TargetNameProperty { get; }

    DependencyProperty ToOffsetProperty { get; }

    DependencyProperty DirectionProperty { get; }
  }
}
