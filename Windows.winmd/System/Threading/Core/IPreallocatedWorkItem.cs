// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.IPreallocatedWorkItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [ExclusiveTo(typeof (PreallocatedWorkItem))]
  [WebHostHidden]
  [Guid(3067783676, 48219, 16410, 168, 178, 110, 117, 77, 20, 218, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPreallocatedWorkItem
  {
    [RemoteAsync]
    IAsyncAction RunAsync();
  }
}
