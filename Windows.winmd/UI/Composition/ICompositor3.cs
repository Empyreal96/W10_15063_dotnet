// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(3386740464, 28337, 20028, 166, 88, 103, 93, 156, 100, 212, 171)]
  [ExclusiveTo(typeof (Compositor))]
  internal interface ICompositor3
  {
    CompositionBackdropBrush CreateHostBackdropBrush();
  }
}
