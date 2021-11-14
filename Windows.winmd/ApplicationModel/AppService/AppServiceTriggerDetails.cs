// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class AppServiceTriggerDetails : 
    IAppServiceTriggerDetails,
    IAppServiceTriggerDetails2
  {
    public extern string Name { [MethodImpl] get; }

    public extern string CallerPackageFamilyName { [MethodImpl] get; }

    public extern AppServiceConnection AppServiceConnection { [MethodImpl] get; }

    public extern bool IsRemoteSystemConnection { [MethodImpl] get; }
  }
}
