// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectedAccessSuspendingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  public sealed class ProtectedAccessSuspendingEventArgs : IProtectedAccessSuspendingEventArgs
  {
    public extern IVectorView<string> Identities { [MethodImpl] get; }

    public extern DateTime Deadline { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
