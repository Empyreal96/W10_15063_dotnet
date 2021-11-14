// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IKeyFrameAnimation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4105472187, 10560, 20160, 164, 26, 235, 109, 128, 26, 47, 24)]
  [WebHostHidden]
  [ExclusiveTo(typeof (KeyFrameAnimation))]
  internal interface IKeyFrameAnimation2
  {
    AnimationDirection Direction { get; set; }
  }
}
