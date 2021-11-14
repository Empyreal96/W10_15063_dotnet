// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintPageInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Muse(Version = 167772162)]
  public sealed class PrintPageInfo : IPrintPageInfo
  {
    [MethodImpl]
    public extern PrintPageInfo();

    public extern PrintMediaSize MediaSize { [MethodImpl] set; [MethodImpl] get; }

    public extern Size PageSize { [MethodImpl] set; [MethodImpl] get; }

    public extern uint DpiX { [MethodImpl] set; [MethodImpl] get; }

    public extern uint DpiY { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintOrientation Orientation { [MethodImpl] set; [MethodImpl] get; }
  }
}
