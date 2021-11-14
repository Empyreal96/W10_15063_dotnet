// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.TimerDestroyedHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(887953914, 33668, 20153, 130, 9, 251, 80, 148, 238, 236, 53)]
  public delegate void TimerDestroyedHandler(ThreadPoolTimer timer);
}
