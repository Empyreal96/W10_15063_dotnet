// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailAttachmentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailAttachment))]
  [Guid(2037296198, 60758, 18809, 135, 8, 171, 184, 188, 133, 75, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailAttachmentFactory
  {
    EmailAttachment Create(string fileName, IRandomAccessStreamReference data);
  }
}
