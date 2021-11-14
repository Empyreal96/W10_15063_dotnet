// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlink2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Hyperlink))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1290394207, 31999, 17041, 183, 143, 223, 236, 114, 73, 5, 118)]
  [WebHostHidden]
  internal interface IHyperlink2
  {
    UnderlineStyle UnderlineStyle { get; set; }
  }
}
