// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.ISignalNotifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(338189830, 25511, 18195, 182, 217, 98, 246, 75, 86, 251, 139)]
  [ExclusiveTo(typeof (SignalNotifier))]
  internal interface ISignalNotifier
  {
    void Enable();

    void Terminate();
  }
}
