// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.AccessListEntryView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AccessListEntryView : IVectorView<AccessListEntry>, IIterable<AccessListEntry>
  {
    [MethodImpl]
    public extern AccessListEntry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(AccessListEntry value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] AccessListEntry[] items);

    [MethodImpl]
    public extern IIterator<AccessListEntry> First();
  }
}
