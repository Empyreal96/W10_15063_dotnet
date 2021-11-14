// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISetter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2805853481, 46254, 19073, 190, 133, 230, 144, 186, 13, 59, 110)]
  [ExclusiveTo(typeof (Setter))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISetter
  {
    DependencyProperty Property { get; set; }

    object Value { get; set; }
  }
}
