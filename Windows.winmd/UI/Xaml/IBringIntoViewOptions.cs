// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IBringIntoViewOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(431870389, 51147, 18137, 164, 221, 161, 187, 232, 62, 242, 251)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BringIntoViewOptions))]
  [WebHostHidden]
  internal interface IBringIntoViewOptions
  {
    bool AnimationDesired { get; set; }

    IReference<Rect> TargetRect { get; set; }
  }
}
