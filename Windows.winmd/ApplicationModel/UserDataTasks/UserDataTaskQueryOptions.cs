// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserDataTaskQueryOptions : IUserDataTaskQueryOptions
  {
    [MethodImpl]
    public extern UserDataTaskQueryOptions();

    public extern UserDataTaskQuerySortProperty SortProperty { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskQueryKind Kind { [MethodImpl] get; [MethodImpl] set; }
  }
}
