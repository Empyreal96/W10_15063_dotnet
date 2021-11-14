// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IXmlLoadSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1487538088, 65238, 18167, 180, 197, 251, 27, 167, 33, 8, 214)]
  [ExclusiveTo(typeof (XmlLoadSettings))]
  internal interface IXmlLoadSettings
  {
    uint MaxElementDepth { get; set; }

    bool ProhibitDtd { get; set; }

    bool ResolveExternals { get; set; }

    bool ValidateOnParse { get; set; }

    bool ElementContentWhiteSpace { get; set; }
  }
}
