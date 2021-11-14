// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusObjectFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(741318411, 36354, 20380, 172, 39, 234, 109, 173, 93, 59, 80)]
  [ExclusiveTo(typeof (AllJoynBusObject))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAllJoynBusObjectFactory
  {
    AllJoynBusObject Create(string objectPath);

    AllJoynBusObject CreateWithBusAttachment(
      string objectPath,
      AllJoynBusAttachment busAttachment);
  }
}
