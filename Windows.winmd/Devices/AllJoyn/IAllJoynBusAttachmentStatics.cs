// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachmentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2208124221, 4177, 16599, 135, 42, 141, 1, 65, 17, 91, 31)]
  internal interface IAllJoynBusAttachmentStatics
  {
    AllJoynBusAttachment GetDefault();

    DeviceWatcher GetWatcher(IIterable<string> requiredInterfaces);
  }
}
