// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Deferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Activatable(typeof (IDeferralFactory), 65536, "Windows.Foundation.FoundationContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Deferral : IDeferral, IClosable
  {
    [MethodImpl]
    public extern Deferral(DeferralCompletedHandler handler);

    [MethodImpl]
    public extern void Complete();

    [MethodImpl]
    public extern void Close();
  }
}
