// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEffectSourceParameter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition
{
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ICompositionEffectSourceParameterFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class CompositionEffectSourceParameter : 
    ICompositionEffectSourceParameter,
    IGraphicsEffectSource
  {
    [MethodImpl]
    public extern CompositionEffectSourceParameter(string name);

    public extern string Name { [MethodImpl] get; }
  }
}
