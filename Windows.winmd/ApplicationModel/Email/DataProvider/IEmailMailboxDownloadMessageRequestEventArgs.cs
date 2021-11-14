// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDownloadMessageRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(1191446957, 53408, 19035, 187, 42, 55, 98, 16, 57, 197, 62)]
  [ExclusiveTo(typeof (EmailMailboxDownloadMessageRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailMailboxDownloadMessageRequestEventArgs
  {
    EmailMailboxDownloadMessageRequest Request { get; }

    Deferral GetDeferral();
  }
}
