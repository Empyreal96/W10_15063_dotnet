// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.IContactRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  [ExclusiveTo(typeof (ContactRemovedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1865761592, 13058, 19731, 173, 141, 173, 204, 15, 249, 228, 124)]
  internal interface IContactRemovedEventArgs
  {
    string Id { get; }
  }
}
