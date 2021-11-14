// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactLaunchActionVerbsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactLaunchActionVerbs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4212273878, 61043, 18151, 135, 97, 17, 205, 1, 87, 114, 143)]
  internal interface IContactLaunchActionVerbsStatics
  {
    string Call { get; }

    string Message { get; }

    string Map { get; }

    string Post { get; }

    string VideoCall { get; }
  }
}
