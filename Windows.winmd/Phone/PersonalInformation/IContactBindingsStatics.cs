// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactBindingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [Guid(3225861307, 39180, 12701, 187, 153, 131, 127, 223, 223, 152, 123)]
  [ExclusiveTo(typeof (ContactBindings))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IContactBindingsStatics
  {
    IAsyncOperation<ContactBindingManager> GetAppContactBindingManagerAsync();
  }
}
