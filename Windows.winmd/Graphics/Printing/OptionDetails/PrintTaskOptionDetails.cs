// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Static(typeof (IPrintTaskOptionDetailsStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100794368)]
  public sealed class PrintTaskOptionDetails : 
    IPrintTaskOptionDetails,
    IPrintTaskOptionsCore,
    IPrintTaskOptionsCoreUIConfiguration
  {
    public extern IMapView<string, IPrintOptionDetails> Options { [MethodImpl] get; }

    [MethodImpl]
    public extern PrintCustomItemListOptionDetails CreateItemListOption(
      string optionId,
      string displayName);

    [MethodImpl]
    public extern PrintCustomTextOptionDetails CreateTextOption(
      string optionId,
      string displayName);

    public extern event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged;

    public extern event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation;

    [MethodImpl]
    public extern PrintPageDescription GetPageDescription(uint jobPageNumber);

    public extern IVector<string> DisplayedOptions { [MethodImpl] get; }

    [MethodImpl]
    public static extern PrintTaskOptionDetails GetFromPrintTaskOptions(
      PrintTaskOptions printTaskOptions);
  }
}
