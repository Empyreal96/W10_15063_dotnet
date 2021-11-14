// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IFadeOutThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2301062057, 65492, 17846, 155, 154, 206, 212, 137, 81, 231, 18)]
  [ExclusiveTo(typeof (FadeOutThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IFadeOutThemeAnimation
  {
    string TargetName { get; set; }
  }
}
