// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationTextFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SyndicationText))]
  [Guid(4000531191, 4550, 19237, 171, 98, 229, 150, 189, 22, 41, 70)]
  internal interface ISyndicationTextFactory
  {
    SyndicationText CreateSyndicationText(string text);

    SyndicationText CreateSyndicationTextEx(string text, SyndicationTextType type);
  }
}
