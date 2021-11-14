// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.Memory.MemoryManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.Memory
{
  [Static(typeof (IMemoryManagerStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public static class MemoryManager
  {
    public static extern ulong ProcessCommittedBytes { [MethodImpl] get; }

    public static extern ulong ProcessCommittedLimit { [MethodImpl] get; }
  }
}
