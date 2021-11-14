// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.TimerElapsedHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4205749863, 64491, 18891, 173, 178, 113, 24, 76, 85, 110, 67)]
  public delegate void TimerElapsedHandler(ThreadPoolTimer timer);
}
