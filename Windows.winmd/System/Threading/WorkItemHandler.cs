// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.WorkItemHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [WebHostHidden]
  [Guid(488278923, 64102, 16719, 156, 189, 182, 95, 201, 157, 23, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void WorkItemHandler(IAsyncAction operation);
}
