// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppMemoryUsageLimitChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(2046322276, 65226, 19877, 158, 64, 43, 198, 62, 253, 201, 121)]
  [ExclusiveTo(typeof (AppMemoryUsageLimitChangingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppMemoryUsageLimitChangingEventArgs
  {
    ulong OldLimit { get; }

    ulong NewLimit { get; }
  }
}
