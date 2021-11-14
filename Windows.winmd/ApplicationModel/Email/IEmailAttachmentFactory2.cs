// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailAttachmentFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(589665333, 20985, 17021, 173, 205, 36, 16, 35, 200, 207, 183)]
  [ExclusiveTo(typeof (EmailAttachment))]
  internal interface IEmailAttachmentFactory2
  {
    EmailAttachment Create(
      string fileName,
      IRandomAccessStreamReference data,
      string mimeType);
  }
}
