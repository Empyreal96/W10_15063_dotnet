// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreCursor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ICoreCursorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CoreCursor : ICoreCursor
  {
    [MethodImpl]
    public extern CoreCursor(CoreCursorType type, uint id);

    public extern uint Id { [MethodImpl] get; }

    public extern CoreCursorType Type { [MethodImpl] get; }
  }
}
