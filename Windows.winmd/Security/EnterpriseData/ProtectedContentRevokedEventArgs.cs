// Decompiled with JetBrains decompiler
// Type: Windows.Security.EnterpriseData.ProtectedContentRevokedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.EnterpriseData
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (EnterpriseDataContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class ProtectedContentRevokedEventArgs : IProtectedContentRevokedEventArgs
  {
    public extern IVectorView<string> Identities { [MethodImpl] get; }
  }
}
