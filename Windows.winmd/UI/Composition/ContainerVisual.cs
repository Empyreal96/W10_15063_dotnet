// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ContainerVisual
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IContainerVisualFactory), CompositionType.Protected, 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class ContainerVisual : Visual, IContainerVisual
  {
    public extern VisualCollection Children { [MethodImpl] get; }
  }
}
