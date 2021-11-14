// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectedAccessResumedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProtectedAccessResumedEventArgs : IProtectedAccessResumedEventArgs
  {
    public extern IVectorView<string> Identities { [MethodImpl] get; }
  }
}
