// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactInstantMessageField
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactInstantMessageField))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3437443895, 3461, 16890, 180, 61, 218, 89, 156, 62, 176, 9)]
  internal interface IContactInstantMessageField : IContactField
  {
    string UserName { get; }

    string Service { get; }

    string DisplayText { get; }

    Uri LaunchUri { get; }
  }
}
