// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactCardDelayedDataLoader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactCardDelayedDataLoader))]
  [Guid(3054172418, 5446, 17229, 134, 156, 110, 53, 32, 118, 14, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactCardDelayedDataLoader : IClosable
  {
    void SetData(Contact contact);
  }
}
