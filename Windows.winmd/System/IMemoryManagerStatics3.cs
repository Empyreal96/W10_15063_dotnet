// Decompiled with JetBrains decompiler
// Type: Windows.System.IMemoryManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (MemoryManager))]
  [Guid(345725390, 37549, 20021, 137, 235, 80, 223, 180, 192, 217, 28)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMemoryManagerStatics3
  {
    bool TrySetAppMemoryUsageLimit(ulong value);
  }
}
