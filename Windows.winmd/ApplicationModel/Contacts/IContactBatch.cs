// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactBatch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactBatch))]
  [Guid(902928173, 49102, 18107, 147, 248, 165, 176, 110, 197, 226, 1)]
  internal interface IContactBatch
  {
    IVectorView<Contact> Contacts { get; }

    ContactBatchStatus Status { get; }
  }
}
