// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4149811847, 44215, 20397, 144, 242, 168, 171, 100, 205, 187, 164)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ContactManager))]
  internal interface IContactManagerStatics5
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsShowFullContactCardSupportedAsync();

    bool IncludeMiddleNameInSystemDisplayAndSort { get; set; }
  }
}
