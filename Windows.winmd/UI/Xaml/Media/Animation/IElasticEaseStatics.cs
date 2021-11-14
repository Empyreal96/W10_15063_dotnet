// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IElasticEaseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ElasticEase))]
  [Guid(2851432172, 65180, 19243, 142, 82, 187, 120, 93, 86, 33, 133)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IElasticEaseStatics
  {
    DependencyProperty OscillationsProperty { get; }

    DependencyProperty SpringinessProperty { get; }
  }
}
