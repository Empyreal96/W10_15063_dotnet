// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IInlineUIContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Guid(337038977, 10478, 17710, 177, 33, 95, 196, 246, 11, 134, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InlineUIContainer))]
  internal interface IInlineUIContainer
  {
    UIElement Child { get; set; }
  }
}
