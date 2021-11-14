// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessageReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(793427615, 25107, 19077, 163, 176, 249, 45, 26, 131, 157, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailMessageReader))]
  internal interface IEmailMessageReader
  {
    [RemoteAsync]
    IAsyncOperation<EmailMessageBatch> ReadBatchAsync();
  }
}
