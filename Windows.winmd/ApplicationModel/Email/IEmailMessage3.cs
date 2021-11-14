// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [Guid(2716493660, 58776, 19753, 160, 24, 252, 123, 126, 236, 224, 161)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (EmailMessage))]
  internal interface IEmailMessage3
  {
    IRandomAccessStreamReference SmimeData { get; set; }

    EmailMessageSmimeKind SmimeKind { get; set; }
  }
}
