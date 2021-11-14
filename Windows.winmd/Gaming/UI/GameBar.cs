// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.GameBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGameBarStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public static class GameBar
  {
    public static extern event EventHandler<object> VisibilityChanged;

    public static extern event EventHandler<object> IsInputRedirectedChanged;

    public static extern bool Visible { [MethodImpl] get; }

    public static extern bool IsInputRedirected { [MethodImpl] get; }
  }
}
