// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.JumpList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IJumpListStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class JumpList : IJumpList
  {
    public extern IVector<JumpListItem> Items { [MethodImpl] get; }

    public extern JumpListSystemGroupKind SystemGroupKind { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<JumpList> LoadCurrentAsync();

    [MethodImpl]
    public static extern bool IsSupported();
  }
}
