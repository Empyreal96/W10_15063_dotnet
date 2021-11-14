// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAboutDataViewStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [Guid(1475196552, 3166, 16750, 136, 181, 57, 179, 45, 37, 196, 125)]
  [ExclusiveTo(typeof (AllJoynAboutDataView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynAboutDataViewStatics
  {
    [RemoteAsync]
    [Overload("GetDataBySessionPortAsync")]
    IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort);

    [RemoteAsync]
    [Overload("GetDataBySessionPortWithLanguageAsync")]
    IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort,
      Language language);
  }
}
