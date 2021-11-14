// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IContentThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(4134520259, 22805, 17277, 142, 59, 173, 248, 231, 240, 171, 87)]
  [ExclusiveTo(typeof (ContentThemeTransition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentThemeTransition
  {
    double HorizontalOffset { get; set; }

    double VerticalOffset { get; set; }
  }
}
