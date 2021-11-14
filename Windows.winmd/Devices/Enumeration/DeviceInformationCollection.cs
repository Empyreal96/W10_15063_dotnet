// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformationCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class DeviceInformationCollection : 
    IVectorView<DeviceInformation>,
    IIterable<DeviceInformation>
  {
    [MethodImpl]
    public extern DeviceInformation GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(DeviceInformation value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] DeviceInformation[] items);

    [MethodImpl]
    public extern IIterator<DeviceInformation> First();
  }
}
