// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEasingColorKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(3342063152, 62649, 18740, 155, 221, 39, 172, 94, 209, 207, 216)]
  [ExclusiveTo(typeof (EasingColorKeyFrame))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEasingColorKeyFrame
  {
    EasingFunctionBase EasingFunction { get; set; }
  }
}
