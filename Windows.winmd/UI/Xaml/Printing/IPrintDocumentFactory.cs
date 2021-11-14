// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPrintDocumentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintDocument))]
  [Guid(4219974031, 9734, 18991, 153, 212, 167, 205, 188, 53, 215, 199)]
  [WebHostHidden]
  internal interface IPrintDocumentFactory
  {
    PrintDocument CreateInstance(object outer, out object inner);
  }
}
