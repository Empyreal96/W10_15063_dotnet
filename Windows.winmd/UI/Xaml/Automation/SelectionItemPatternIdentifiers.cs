// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.SelectionItemPatternIdentifiers
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
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISelectionItemPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SelectionItemPatternIdentifiers : ISelectionItemPatternIdentifiers
  {
    public static extern AutomationProperty IsSelectedProperty { [MethodImpl] get; }

    public static extern AutomationProperty SelectionContainerProperty { [MethodImpl] get; }
  }
}
