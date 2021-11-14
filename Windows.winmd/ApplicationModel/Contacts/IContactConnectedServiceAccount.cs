// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactConnectedServiceAccount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4143461715, 43559, 18225, 142, 74, 61, 236, 92, 233, 238, 201)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactConnectedServiceAccount))]
  internal interface IContactConnectedServiceAccount
  {
    string Id { get; set; }

    string ServiceName { get; set; }
  }
}
