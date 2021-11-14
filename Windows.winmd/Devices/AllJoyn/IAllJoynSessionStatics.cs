// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSessionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2651182596, 41068, 18132, 180, 108, 11, 11, 84, 16, 91, 68)]
  [ExclusiveTo(typeof (AllJoynSession))]
  internal interface IAllJoynSessionStatics
  {
    [Overload("GetFromServiceInfoAsync")]
    [RemoteAsync]
    IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo);

    [Overload("GetFromServiceInfoAndBusAttachmentAsync")]
    [RemoteAsync]
    IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo,
      AllJoynBusAttachment busAttachment);
  }
}
