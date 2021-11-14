// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IKeyFrameAnimation3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (KeyFrameAnimation))]
  [Guid(2220617908, 55518, 17967, 135, 83, 200, 13, 67, 198, 255, 90)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IKeyFrameAnimation3
  {
    AnimationDelayBehavior DelayBehavior { get; set; }
  }
}
