// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IDtdNotation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ExclusiveTo(typeof (DtdNotation))]
  [Guid(2360664141, 27974, 20187, 171, 115, 223, 131, 197, 26, 211, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDtdNotation : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    object PublicId { [return: Variant] get; }

    object SystemId { [return: Variant] get; }
  }
}
