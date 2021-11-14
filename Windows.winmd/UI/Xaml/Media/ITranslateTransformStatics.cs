// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITranslateTransformStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(4095322769, 57410, 16657, 156, 47, 210, 1, 48, 65, 35, 221)]
  [ExclusiveTo(typeof (TranslateTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITranslateTransformStatics
  {
    DependencyProperty XProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty YProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
