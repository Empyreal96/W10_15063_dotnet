// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockOverflow2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2269274702, 43138, 18470, 185, 41, 77, 92, 57, 5, 185, 161)]
  [ExclusiveTo(typeof (RichTextBlockOverflow))]
  [WebHostHidden]
  internal interface IRichTextBlockOverflow2
  {
    int MaxLines { get; set; }
  }
}
