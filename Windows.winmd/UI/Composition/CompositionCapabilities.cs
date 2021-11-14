// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Static(typeof (ICompositionCapabilitiesStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionCapabilities : ICompositionCapabilities
  {
    [MethodImpl]
    public extern bool AreEffectsSupported();

    [MethodImpl]
    public extern bool AreEffectsFast();

    public extern event TypedEventHandler<CompositionCapabilities, object> Changed;

    [MethodImpl]
    public static extern CompositionCapabilities GetForCurrentView();
  }
}
