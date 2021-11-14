// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3098446357, 3939, 18068, 148, 103, 189, 175, 172, 18, 83, 234)]
  [ExclusiveTo(typeof (ColorAnimation))]
  [WebHostHidden]
  internal interface IColorAnimation
  {
    IReference<Color> From { get; set; }

    IReference<Color> To { get; set; }

    IReference<Color> By { get; set; }

    EasingFunctionBase EasingFunction { get; set; }

    bool EnableDependentAnimation { get; set; }
  }
}
