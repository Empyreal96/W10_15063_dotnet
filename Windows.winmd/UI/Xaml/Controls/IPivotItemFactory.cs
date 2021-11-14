// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(231659905, 25454, 18996, 138, 63, 142, 224, 24, 99, 146, 133)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PivotItem))]
  internal interface IPivotItemFactory
  {
    PivotItem CreateInstance(object outer, out object inner);
  }
}
