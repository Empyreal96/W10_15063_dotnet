// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2886020515, 45460, 16989, 182, 217, 208, 240, 65, 53, 237, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailManager))]
  internal interface IEmailManagerStatics2
  {
    [RemoteAsync]
    IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);
  }
}
