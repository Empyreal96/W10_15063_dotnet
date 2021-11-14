// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ISyndicationGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SyndicationGenerator : ISyndicationGenerator, ISyndicationNode
  {
    [MethodImpl]
    public extern SyndicationGenerator(string text);

    [MethodImpl]
    public extern SyndicationGenerator();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    public extern string Version { [MethodImpl] get; [MethodImpl] set; }

    public extern string NodeName { [MethodImpl] get; [MethodImpl] set; }

    public extern string NodeNamespace { [MethodImpl] get; [MethodImpl] set; }

    public extern string NodeValue { [MethodImpl] get; [MethodImpl] set; }

    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri BaseUri { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<SyndicationAttribute> AttributeExtensions { [MethodImpl] get; }

    public extern IVector<ISyndicationNode> ElementExtensions { [MethodImpl] get; }

    [MethodImpl]
    public extern XmlDocument GetXmlDocument(SyndicationFormat format);
  }
}
