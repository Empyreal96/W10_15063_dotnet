// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactDataProviderTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ExclusiveTo(typeof (ContactDataProviderTriggerDetails))]
  [Guid(1383138494, 15458, 17352, 154, 231, 219, 83, 22, 133, 205, 153)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IContactDataProviderTriggerDetails
  {
    ContactDataProviderConnection Connection { get; }
  }
}
