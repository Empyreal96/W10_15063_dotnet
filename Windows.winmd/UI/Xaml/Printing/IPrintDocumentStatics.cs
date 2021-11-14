// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPrintDocumentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4254534204, 45394, 18912, 166, 189, 106, 166, 71, 126, 67, 199)]
  [ExclusiveTo(typeof (PrintDocument))]
  [WebHostHidden]
  internal interface IPrintDocumentStatics
  {
    DependencyProperty DocumentSourceProperty { get; }
  }
}
