// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.Pointer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class Pointer : IPointer
  {
    public extern uint PointerId { [MethodImpl] get; }

    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    public extern bool IsInContact { [MethodImpl] get; }

    public extern bool IsInRange { [MethodImpl] get; }
  }
}
