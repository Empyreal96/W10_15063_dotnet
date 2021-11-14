// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEasingDoubleKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2522536845, 39508, 16648, 180, 255, 181, 165, 33, 44, 179, 56)]
  [WebHostHidden]
  [ExclusiveTo(typeof (EasingDoubleKeyFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEasingDoubleKeyFrame
  {
    EasingFunctionBase EasingFunction { get; set; }
  }
}
