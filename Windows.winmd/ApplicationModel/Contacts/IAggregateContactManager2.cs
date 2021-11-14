// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IAggregateContactManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1586283224, 43469, 17456, 156, 75, 1, 52, 141, 178, 202, 80)]
  [ExclusiveTo(typeof (AggregateContactManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAggregateContactManager2
  {
    [RemoteAsync]
    IAsyncAction SetRemoteIdentificationInformationAsync(
      string contactListId,
      string remoteSourceId,
      string accountId);
  }
}
