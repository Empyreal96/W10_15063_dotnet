// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmSessionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IMdmSessionManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class MdmSessionManager
  {
    public static extern IVectorView<string> SessionIds { [MethodImpl] get; }

    [MethodImpl]
    public static extern MdmSession TryCreateSession();

    [MethodImpl]
    public static extern void DeleteSessionById(string sessionId);

    [MethodImpl]
    public static extern MdmSession GetSessionById(string sessionId);
  }
}
