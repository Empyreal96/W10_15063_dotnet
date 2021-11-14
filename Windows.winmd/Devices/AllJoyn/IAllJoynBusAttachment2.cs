// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachment2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  [Guid(880069406, 9064, 17330, 180, 62, 106, 58, 193, 39, 141, 152)]
  internal interface IAllJoynBusAttachment2
  {
    [Overload("GetAboutDataAsync")]
    [RemoteAsync]
    IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo);

    [Overload("GetAboutDataWithLanguageAsync")]
    [RemoteAsync]
    IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo,
      Language language);

    event TypedEventHandler<AllJoynBusAttachment, AllJoynAcceptSessionJoinerEventArgs> AcceptSessionJoinerRequested;

    event TypedEventHandler<AllJoynBusAttachment, AllJoynSessionJoinedEventArgs> SessionJoined;
  }
}
