// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IdleDispatchedHandlerArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [WebHostHidden]
  public sealed class IdleDispatchedHandlerArgs : IIdleDispatchedHandlerArgs
  {
    public extern bool IsDispatcherIdle { [MethodImpl] get; }
  }
}
