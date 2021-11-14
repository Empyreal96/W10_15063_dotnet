// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerControlAcquiredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  public sealed class RadialControllerControlAcquiredEventArgs : 
    IRadialControllerControlAcquiredEventArgs,
    IRadialControllerControlAcquiredEventArgs2
  {
    public extern RadialControllerScreenContact Contact { [MethodImpl] get; }

    public extern bool IsButtonPressed { [MethodImpl] get; }

    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }
  }
}
