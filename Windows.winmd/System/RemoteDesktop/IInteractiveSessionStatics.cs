// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteDesktop.IInteractiveSessionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteDesktop
{
  [Guid(1619543601, 56634, 17782, 156, 141, 232, 2, 118, 24, 189, 206)]
  [ExclusiveTo(typeof (InteractiveSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInteractiveSessionStatics
  {
    bool IsRemote { get; }
  }
}
