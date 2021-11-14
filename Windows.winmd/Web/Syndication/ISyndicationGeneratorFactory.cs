// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationGeneratorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationGenerator))]
  [Guid(2738914275, 7718, 19900, 186, 157, 26, 184, 75, 239, 249, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationGeneratorFactory
  {
    SyndicationGenerator CreateSyndicationGenerator(string text);
  }
}
