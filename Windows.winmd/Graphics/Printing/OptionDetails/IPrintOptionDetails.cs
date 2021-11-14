// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(956729039, 54914, 18783, 173, 254, 215, 51, 63, 92, 24, 8)]
  public interface IPrintOptionDetails
  {
    string OptionId { get; }

    PrintOptionType OptionType { get; }

    string ErrorText { set; get; }

    PrintOptionStates State { set; get; }

    object Value { [return: Variant] get; }

    bool TrySetValue([Variant] object value);
  }
}
