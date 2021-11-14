// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxServerSearchReadBatchRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [Guid(336599886, 60830, 17873, 173, 122, 204, 155, 127, 100, 58, 226)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxServerSearchReadBatchRequestEventArgs))]
  internal interface IEmailMailboxServerSearchReadBatchRequestEventArgs
  {
    EmailMailboxServerSearchReadBatchRequest Request { get; }

    Deferral GetDeferral();
  }
}
