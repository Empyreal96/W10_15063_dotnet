// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContact
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (Contact))]
  [Guid(3959452403, 8472, 16457, 158, 188, 23, 240, 171, 105, 43, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContact
  {
    string Name { get; set; }

    IRandomAccessStreamReference Thumbnail { get; set; }

    IVector<IContactField> Fields { get; }
  }
}
