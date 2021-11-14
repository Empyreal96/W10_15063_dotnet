// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailConversationReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(3026390914, 10357, 17608, 155, 140, 133, 190, 179, 163, 198, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailConversationReader))]
  internal interface IEmailConversationReader
  {
    [RemoteAsync]
    IAsyncOperation<EmailConversationBatch> ReadBatchAsync();
  }
}
