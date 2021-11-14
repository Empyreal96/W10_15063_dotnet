// Decompiled with JetBrains decompiler
// Type: Windows.Data.Xml.Dom.IDtdEntity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Xml.Dom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1779130364, 25524, 18447, 158, 106, 138, 146, 129, 106, 173, 228)]
  [ExclusiveTo(typeof (DtdEntity))]
  internal interface IDtdEntity : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
  {
    object PublicId { [return: Variant] get; }

    object SystemId { [return: Variant] get; }

    object NotationName { [return: Variant] get; }
  }
}
