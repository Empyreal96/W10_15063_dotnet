// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISelectorItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1411157356, 643, 17793, 185, 69, 42, 100, 194, 138, 6, 70)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SelectorItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectorItem
  {
    bool IsSelected { get; set; }
  }
}
