// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.SettingsCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ApplicationSettings
{
  [Activatable(typeof (ISettingsCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISettingsCommandStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.None)]
  [DualApiPartition(version = 167772162)]
  [Muse(Version = 100794368)]
  public sealed class SettingsCommand : IUICommand
  {
    [MethodImpl]
    public extern SettingsCommand(
      [Variant] object settingsCommandId,
      string label,
      UICommandInvokedHandler handler);

    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    public extern UICommandInvokedHandler Invoked { [MethodImpl] get; [MethodImpl] set; }

    public extern object Id { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    public static extern SettingsCommand AccountsCommand { [MethodImpl] get; }
  }
}
