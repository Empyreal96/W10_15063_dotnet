// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationText
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
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ISyndicationTextFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SyndicationText : ISyndicationText, ISyndicationNode
  {
    [MethodImpl]
    public extern SyndicationText(string text);

    [MethodImpl]
    public extern SyndicationText(string text, SyndicationTextType type);

    [MethodImpl]
    public extern SyndicationText();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern string Type { [MethodImpl] get; [MethodImpl] set; }

    public extern XmlDocument Xml { [MethodImpl] get; [MethodImpl] set; }

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
