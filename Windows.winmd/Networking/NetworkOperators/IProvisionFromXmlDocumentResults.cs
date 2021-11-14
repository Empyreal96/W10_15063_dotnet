// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IProvisionFromXmlDocumentResults
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(561447136, 33283, 4575, 173, 185, 244, 206, 70, 45, 145, 55)]
  [ExclusiveTo(typeof (ProvisionFromXmlDocumentResults))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProvisionFromXmlDocumentResults
  {
    bool AllElementsProvisioned { get; }

    string ProvisionResultsXml { get; }
  }
}
