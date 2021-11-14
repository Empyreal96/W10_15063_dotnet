// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailQueryTextSearch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2678104712, 15453, 18085, 166, 226, 49, 214, 253, 23, 229, 64)]
  [ExclusiveTo(typeof (EmailQueryTextSearch))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailQueryTextSearch
  {
    EmailQuerySearchFields Fields { get; set; }

    EmailQuerySearchScope SearchScope { get; set; }

    string Text { get; set; }
  }
}
