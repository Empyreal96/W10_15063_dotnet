// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.RangeValuePatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRangeValuePatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RangeValuePatternIdentifiers : IRangeValuePatternIdentifiers
  {
    public static extern AutomationProperty IsReadOnlyProperty { [MethodImpl] get; }

    public static extern AutomationProperty LargeChangeProperty { [MethodImpl] get; }

    public static extern AutomationProperty MaximumProperty { [MethodImpl] get; }

    public static extern AutomationProperty MinimumProperty { [MethodImpl] get; }

    public static extern AutomationProperty SmallChangeProperty { [MethodImpl] get; }

    public static extern AutomationProperty ValueProperty { [MethodImpl] get; }
  }
}
