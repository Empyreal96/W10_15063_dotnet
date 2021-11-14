// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Core.RadialControllerIndependentInputSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Core
{
  [Static(typeof (IRadialControllerIndependentInputSourceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RadialControllerIndependentInputSource : 
    IRadialControllerIndependentInputSource
  {
    public extern RadialController Controller { [MethodImpl] get; }

    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    [MethodImpl]
    public static extern RadialControllerIndependentInputSource CreateForView(
      CoreApplicationView view);
  }
}
