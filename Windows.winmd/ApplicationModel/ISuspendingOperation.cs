// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ISuspendingOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2644822593, 8417, 20123, 159, 101, 169, 244, 53, 52, 12, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISuspendingOperation
  {
    SuspendingDeferral GetDeferral();

    DateTime Deadline { get; }
  }
}
