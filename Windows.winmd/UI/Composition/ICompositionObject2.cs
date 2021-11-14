// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionObject2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(4018622113, 23807, 19304, 158, 48, 161, 81, 157, 8, 186, 3)]
  [ExclusiveTo(typeof (CompositionObject))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface ICompositionObject2
  {
    string Comment { get; set; }

    ImplicitAnimationCollection ImplicitAnimations { get; set; }

    void StartAnimationGroup(ICompositionAnimationBase value);

    void StopAnimationGroup(ICompositionAnimationBase value);
  }
}
