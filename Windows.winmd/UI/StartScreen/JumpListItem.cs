// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.JumpListItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IJumpListItemStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class JumpListItem : IJumpListItem
  {
    public extern JumpListItemKind Kind { [MethodImpl] get; }

    public extern string Arguments { [MethodImpl] get; }

    public extern bool RemovedByUser { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string GroupName { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Logo { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern JumpListItem CreateWithArguments(
      string arguments,
      string displayName);

    [MethodImpl]
    public static extern JumpListItem CreateSeparator();
  }
}
