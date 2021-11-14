// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskRegenerationProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataTaskRegenerationProperties : IUserDataTaskRegenerationProperties
  {
    [MethodImpl]
    public extern UserDataTaskRegenerationProperties();

    public extern UserDataTaskRegenerationUnit Unit { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<int> Occurrences { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> Until { [MethodImpl] get; [MethodImpl] set; }

    public extern int Interval { [MethodImpl] get; [MethodImpl] set; }
  }
}
