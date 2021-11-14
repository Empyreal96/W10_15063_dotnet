// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxChangeReader))]
  [Guid(3183283899, 50493, 17201, 151, 190, 190, 117, 162, 20, 106, 117)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxChangeReader
  {
    void AcceptChanges();

    void AcceptChangesThrough(EmailMailboxChange lastChangeToAcknowledge);

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMailboxChange>> ReadBatchAsync();
  }
}
