// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPopOutThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (PopOutThemeAnimation))]
  [WebHostHidden]
  [Guid(1200008009, 3656, 20097, 162, 229, 204, 90, 161, 158, 72, 211)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPopOutThemeAnimation
  {
    string TargetName { get; set; }
  }
}
