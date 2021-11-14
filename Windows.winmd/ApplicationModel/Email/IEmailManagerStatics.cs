// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4111631956, 21957, 18576, 168, 36, 33, 108, 38, 24, 206, 127)]
  internal interface IEmailManagerStatics
  {
    [RemoteAsync]
    IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);
  }
}
