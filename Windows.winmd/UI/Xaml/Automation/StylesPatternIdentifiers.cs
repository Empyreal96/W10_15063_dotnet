// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.StylesPatternIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IStylesPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class StylesPatternIdentifiers : IStylesPatternIdentifiers
  {
    public static extern AutomationProperty ExtendedPropertiesProperty { [MethodImpl] get; }

    public static extern AutomationProperty FillColorProperty { [MethodImpl] get; }

    public static extern AutomationProperty FillPatternColorProperty { [MethodImpl] get; }

    public static extern AutomationProperty FillPatternStyleProperty { [MethodImpl] get; }

    public static extern AutomationProperty ShapeProperty { [MethodImpl] get; }

    public static extern AutomationProperty StyleIdProperty { [MethodImpl] get; }

    public static extern AutomationProperty StyleNameProperty { [MethodImpl] get; }
  }
}
