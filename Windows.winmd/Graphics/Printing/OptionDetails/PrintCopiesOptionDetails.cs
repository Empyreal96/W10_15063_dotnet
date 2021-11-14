// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintCopiesOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintCopiesOptionDetails : IPrintOptionDetails, IPrintNumberOptionDetails
  {
    public extern string OptionId { [MethodImpl] get; }

    public extern PrintOptionType OptionType { [MethodImpl] get; }

    public extern string ErrorText { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintOptionStates State { [MethodImpl] set; [MethodImpl] get; }

    public extern object Value { [MethodImpl] [return: Variant] get; }

    [MethodImpl]
    public extern bool TrySetValue([Variant] object value);

    public extern uint MinValue { [MethodImpl] get; }

    public extern uint MaxValue { [MethodImpl] get; }
  }
}
