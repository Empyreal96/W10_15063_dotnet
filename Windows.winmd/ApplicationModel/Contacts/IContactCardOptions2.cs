// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactCardOptions2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (ContactCardOptions))]
  [Guid(2401704864, 55115, 19654, 159, 83, 27, 14, 181, 209, 39, 60)]
  internal interface IContactCardOptions2 : IContactCardOptions
  {
    IVector<string> ServerSearchContactListIds { get; }
  }
}
