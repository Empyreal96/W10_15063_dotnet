// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.GridItemPatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGridItemPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class GridItemPatternIdentifiers : IGridItemPatternIdentifiers
  {
    public static extern AutomationProperty ColumnProperty { [MethodImpl] get; }

    public static extern AutomationProperty ColumnSpanProperty { [MethodImpl] get; }

    public static extern AutomationProperty ContainingGridProperty { [MethodImpl] get; }

    public static extern AutomationProperty RowProperty { [MethodImpl] get; }

    public static extern AutomationProperty RowSpanProperty { [MethodImpl] get; }
  }
}
