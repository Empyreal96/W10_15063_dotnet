// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerScreenContact
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RadialControllerScreenContact : IRadialControllerScreenContact
  {
    public extern Rect Bounds { [MethodImpl] get; }

    public extern Point Position { [MethodImpl] get; }
  }
}
