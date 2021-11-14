// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynBusObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IAllJoynBusObjectFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AllJoynBusObject : IAllJoynBusObject
  {
    [MethodImpl]
    public extern AllJoynBusObject(string objectPath);

    [MethodImpl]
    public extern AllJoynBusObject(string objectPath, AllJoynBusAttachment busAttachment);

    [MethodImpl]
    public extern AllJoynBusObject();

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void AddProducer(IAllJoynProducer producer);

    public extern AllJoynBusAttachment BusAttachment { [MethodImpl] get; }

    public extern AllJoynSession Session { [MethodImpl] get; }

    public extern event TypedEventHandler<AllJoynBusObject, AllJoynBusObjectStoppedEventArgs> Stopped;
  }
}
