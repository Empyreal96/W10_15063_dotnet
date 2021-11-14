// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SimpleOrientationSensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISimpleOrientationSensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SimpleOrientationSensor : 
    ISimpleOrientationSensor,
    ISimpleOrientationSensorDeviceId,
    ISimpleOrientationSensor2
  {
    [MethodImpl]
    public extern SimpleOrientation GetCurrentOrientation();

    public extern event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged;

    public extern string DeviceId { [MethodImpl] get; }

    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public static extern SimpleOrientationSensor GetDefault();
  }
}
