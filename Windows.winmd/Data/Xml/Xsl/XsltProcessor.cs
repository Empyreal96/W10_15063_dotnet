// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Xsl.XsltProcessor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Xsl
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IXsltProcessorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class XsltProcessor : IXsltProcessor, IXsltProcessor2
  {
    [MethodImpl]
    public extern XsltProcessor(XmlDocument document);

    [MethodImpl]
    public extern string TransformToString(IXmlNode inputNode);

    [MethodImpl]
    public extern XmlDocument TransformToDocument(IXmlNode inputNode);
  }
}
