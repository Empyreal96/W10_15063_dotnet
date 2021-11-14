// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.CharacterGroupings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ICharacterGroupingsFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CharacterGroupings : 
    ICharacterGroupings,
    IVectorView<CharacterGrouping>,
    IIterable<CharacterGrouping>
  {
    [MethodImpl]
    public extern CharacterGroupings(string language);

    [MethodImpl]
    public extern CharacterGroupings();

    [MethodImpl]
    public extern string Lookup(string text);

    [MethodImpl]
    public extern CharacterGrouping GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(CharacterGrouping value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] CharacterGrouping[] items);

    [MethodImpl]
    public extern IIterator<CharacterGrouping> First();
  }
}
