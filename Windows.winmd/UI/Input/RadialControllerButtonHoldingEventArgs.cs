// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerButtonHoldingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RadialControllerButtonHoldingEventArgs : 
    IRadialControllerButtonHoldingEventArgs
  {
    public extern RadialControllerScreenContact Contact { [MethodImpl] get; }

    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }
  }
}
