// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteDesktop.InteractiveSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteDesktop
{
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInteractiveSessionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class InteractiveSession
  {
    public static extern bool IsRemote { [MethodImpl] get; }
  }
}
