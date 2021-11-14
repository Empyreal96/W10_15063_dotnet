// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationPersonFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3707013229, 8861, 19288, 164, 155, 243, 210, 240, 245, 201, 159)]
  [ExclusiveTo(typeof (SyndicationPerson))]
  internal interface ISyndicationPersonFactory
  {
    SyndicationPerson CreateSyndicationPerson(string name);

    SyndicationPerson CreateSyndicationPersonEx(
      string name,
      string email,
      Uri uri);
  }
}
