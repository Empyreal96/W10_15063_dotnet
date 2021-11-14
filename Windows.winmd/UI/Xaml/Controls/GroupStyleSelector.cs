// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.GroupStyleSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IGroupStyleSelectorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class GroupStyleSelector : IGroupStyleSelector, IGroupStyleSelectorOverrides
  {
    [MethodImpl]
    public extern GroupStyleSelector();

    [MethodImpl]
    public extern GroupStyle SelectGroupStyle(object group, uint level);

    [MethodImpl]
    extern GroupStyle IGroupStyleSelectorOverrides.SelectGroupStyleCore(
      object group,
      uint level);
  }
}
