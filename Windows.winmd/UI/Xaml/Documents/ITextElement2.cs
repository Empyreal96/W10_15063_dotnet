// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2819058344, 63634, 18934, 140, 210, 137, 173, 218, 240, 109, 45)]
  [ExclusiveTo(typeof (TextElement))]
  [WebHostHidden]
  internal interface ITextElement2
  {
    bool IsTextScaleFactorEnabled { get; set; }
  }
}
