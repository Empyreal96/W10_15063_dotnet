// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmAlert
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MdmAlert : IMdmAlert
  {
    [MethodImpl]
    public extern MdmAlert();

    public extern string Data { [MethodImpl] get; [MethodImpl] set; }

    public extern MdmAlertDataType Format { [MethodImpl] get; [MethodImpl] set; }

    public extern MdmAlertMark Mark { [MethodImpl] get; [MethodImpl] set; }

    public extern string Source { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Status { [MethodImpl] get; }

    public extern string Target { [MethodImpl] get; [MethodImpl] set; }

    public extern string Type { [MethodImpl] get; [MethodImpl] set; }
  }
}
