// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationPerson
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4196328922, 42950, 17687, 160, 150, 1, 67, 250, 242, 147, 39)]
  [ExclusiveTo(typeof (SyndicationPerson))]
  internal interface ISyndicationPerson : ISyndicationNode
  {
    string Email { get; set; }

    string Name { get; set; }

    Uri Uri { get; set; }
  }
}
