// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxGetAutoReplySettingsRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxGetAutoReplySettingsRequestEventArgs))]
  [Guid(3617543618, 64837, 16388, 138, 145, 155, 172, 243, 139, 112, 34)]
  internal interface IEmailMailboxGetAutoReplySettingsRequestEventArgs
  {
    EmailMailboxGetAutoReplySettingsRequest Request { get; }

    Deferral GetDeferral();
  }
}
