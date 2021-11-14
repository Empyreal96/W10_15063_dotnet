// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicSpace
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.UI.Core;

namespace Windows.Graphics.Holographic
{
  [Static(typeof (IHolographicSpaceStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHolographicSpaceStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class HolographicSpace : IHolographicSpace
  {
    public extern HolographicAdapterId PrimaryAdapterId { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetDirect3D11Device(IDirect3DDevice value);

    public extern event TypedEventHandler<HolographicSpace, HolographicSpaceCameraAddedEventArgs> CameraAdded;

    public extern event TypedEventHandler<HolographicSpace, HolographicSpaceCameraRemovedEventArgs> CameraRemoved;

    [MethodImpl]
    public extern HolographicFrame CreateNextFrame();

    public static extern bool IsSupported { [MethodImpl] get; }

    public static extern bool IsAvailable { [MethodImpl] get; }

    public static extern event EventHandler<object> IsAvailableChanged;

    [MethodImpl]
    public static extern HolographicSpace CreateForCoreWindow(CoreWindow window);
  }
}
