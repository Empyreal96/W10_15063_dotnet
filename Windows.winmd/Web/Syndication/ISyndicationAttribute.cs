// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(1911093609, 21102, 16385, 154, 145, 232, 79, 131, 22, 26, 177)]
  [ExclusiveTo(typeof (SyndicationAttribute))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationAttribute
  {
    string Name { get; set; }

    string Namespace { get; set; }

    string Value { get; set; }
  }
}
