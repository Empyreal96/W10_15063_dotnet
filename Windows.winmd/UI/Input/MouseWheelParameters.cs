// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.MouseWheelParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MouseWheelParameters : IMouseWheelParameters
  {
    public extern Point CharTranslation { [MethodImpl] get; [MethodImpl] set; }

    public extern float DeltaScale { [MethodImpl] get; [MethodImpl] set; }

    public extern float DeltaRotationAngle { [MethodImpl] get; [MethodImpl] set; }

    public extern Point PageTranslation { [MethodImpl] get; [MethodImpl] set; }
  }
}
