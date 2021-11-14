// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(4117891825, 43166, 17062, 129, 175, 248, 224, 16, 179, 138, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskOptionDetails))]
  internal interface IPrintTaskOptionDetails
  {
    IMapView<string, IPrintOptionDetails> Options { get; }

    PrintCustomItemListOptionDetails CreateItemListOption(
      string optionId,
      string displayName);

    PrintCustomTextOptionDetails CreateTextOption(
      string optionId,
      string displayName);

    event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged;

    event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation;
  }
}
