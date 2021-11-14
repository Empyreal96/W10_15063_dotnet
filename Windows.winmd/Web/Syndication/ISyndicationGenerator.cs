// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2540221305, 64299, 20333, 180, 28, 8, 138, 88, 104, 130, 92)]
  internal interface ISyndicationGenerator
  {
    string Text { get; set; }

    Uri Uri { get; set; }

    string Version { get; set; }
  }
}
