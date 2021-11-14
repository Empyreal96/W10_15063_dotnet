// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailAttachment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailAttachment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4082354937, 22472, 19163, 185, 146, 96, 252, 235, 88, 79, 84)]
  internal interface IEmailAttachment
  {
    string FileName { get; set; }

    IRandomAccessStreamReference Data { get; set; }
  }
}
