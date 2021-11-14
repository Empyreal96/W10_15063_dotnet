// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationClientFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SyndicationClient))]
  [Guid(784642860, 42907, 16660, 178, 154, 5, 223, 251, 175, 185, 164)]
  internal interface ISyndicationClientFactory
  {
    SyndicationClient CreateSyndicationClient(PasswordCredential serverCredential);
  }
}
