// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Preview.Holographic.HolographicApplicationPreview
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Preview.Holographic
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHolographicApplicationPreviewStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class HolographicApplicationPreview
  {
    [MethodImpl]
    public static extern bool IsCurrentViewPresentedOnHolographicDisplay();

    [MethodImpl]
    public static extern bool IsHolographicActivation(IActivatedEventArgs activatedEventArgs);
  }
}
