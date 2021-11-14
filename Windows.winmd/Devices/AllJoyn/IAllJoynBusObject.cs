// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynBusObject))]
  [Guid(3908928094, 63290, 18700, 136, 4, 4, 224, 38, 100, 48, 71)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAllJoynBusObject
  {
    void Start();

    void Stop();

    void AddProducer(IAllJoynProducer producer);

    AllJoynBusAttachment BusAttachment { get; }

    AllJoynSession Session { get; }

    event TypedEventHandler<AllJoynBusObject, AllJoynBusObjectStoppedEventArgs> Stopped;
  }
}
