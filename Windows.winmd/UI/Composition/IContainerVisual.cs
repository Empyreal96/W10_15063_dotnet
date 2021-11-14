// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IContainerVisual
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (ContainerVisual))]
  [Guid(49724532, 60704, 18291, 175, 230, 212, 155, 74, 147, 219, 50)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IContainerVisual
  {
    VisualCollection Children { get; }
  }
}
