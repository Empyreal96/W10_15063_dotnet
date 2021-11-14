// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailManagerForUser))]
  [Guid(4151565983, 15525, 19215, 144, 193, 21, 110, 64, 23, 76, 229)]
  internal interface IEmailManagerForUser
  {
    [RemoteAsync]
    IAsyncAction ShowComposeNewEmailAsync(EmailMessage message);

    [RemoteAsync]
    IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);

    User User { get; }
  }
}
