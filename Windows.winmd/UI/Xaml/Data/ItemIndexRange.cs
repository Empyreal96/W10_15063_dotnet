// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ItemIndexRange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IItemIndexRangeFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ItemIndexRange : IItemIndexRange
  {
    [MethodImpl]
    public extern ItemIndexRange(int firstIndex, uint length);

    public extern int FirstIndex { [MethodImpl] get; }

    public extern uint Length { [MethodImpl] get; }

    public extern int LastIndex { [MethodImpl] get; }
  }
}
