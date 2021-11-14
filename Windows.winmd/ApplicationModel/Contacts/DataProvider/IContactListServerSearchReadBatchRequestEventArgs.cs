// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListServerSearchReadBatchRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ContactListServerSearchReadBatchRequestEventArgs))]
  [Guid(438823035, 27095, 20046, 128, 66, 134, 28, 186, 97, 71, 30)]
  internal interface IContactListServerSearchReadBatchRequestEventArgs
  {
    ContactListServerSearchReadBatchRequest Request { get; }

    Deferral GetDeferral();
  }
}
