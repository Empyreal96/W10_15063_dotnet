// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InertiaRotationBehavior
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class InertiaRotationBehavior : IInertiaRotationBehavior
  {
    public extern double DesiredDeceleration { [MethodImpl] get; [MethodImpl] set; }

    public extern double DesiredRotation { [MethodImpl] get; [MethodImpl] set; }
  }
}
