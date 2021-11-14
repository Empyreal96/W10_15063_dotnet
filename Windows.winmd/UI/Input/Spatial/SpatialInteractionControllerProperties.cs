// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionControllerProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class SpatialInteractionControllerProperties : 
    ISpatialInteractionControllerProperties
  {
    public extern bool IsTouchpadTouched { [MethodImpl] get; }

    public extern bool IsTouchpadPressed { [MethodImpl] get; }

    public extern bool IsThumbstickPressed { [MethodImpl] get; }

    public extern double ThumbstickX { [MethodImpl] get; }

    public extern double ThumbstickY { [MethodImpl] get; }

    public extern double TouchpadX { [MethodImpl] get; }

    public extern double TouchpadY { [MethodImpl] get; }
  }
}
