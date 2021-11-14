// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(453673358, 9513, 18274, 186, 68, 154, 188, 104, 195, 206, 202)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Pivot))]
  internal interface IPivotFactory
  {
    Pivot CreateInstance(object outer, out object inner);
  }
}
