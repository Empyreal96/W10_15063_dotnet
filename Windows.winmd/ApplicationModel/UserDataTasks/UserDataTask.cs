// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataTask : IUserDataTask
  {
    [MethodImpl]
    public extern UserDataTask();

    public extern string Id { [MethodImpl] get; }

    public extern string ListId { [MethodImpl] get; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> CompletedDate { [MethodImpl] get; [MethodImpl] set; }

    public extern string Details { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskDetailsKind DetailsKind { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> DueDate { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskKind Kind { [MethodImpl] get; }

    public extern UserDataTaskPriority Priority { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskRecurrenceProperties RecurrenceProperties { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskRegenerationProperties RegenerationProperties { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> Reminder { [MethodImpl] get; [MethodImpl] set; }

    public extern UserDataTaskSensitivity Sensitivity { [MethodImpl] get; [MethodImpl] set; }

    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> StartDate { [MethodImpl] get; [MethodImpl] set; }
  }
}
