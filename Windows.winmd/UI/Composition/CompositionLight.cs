// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ICompositionLightFactory), CompositionType.Protected, 196608, "Windows.Foundation.UniversalApiContract")]
  public class CompositionLight : CompositionObject, ICompositionLight
  {
    public extern VisualUnorderedCollection Targets { [MethodImpl] get; }
  }
}
