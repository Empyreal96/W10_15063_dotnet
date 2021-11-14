// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextServicesManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Text.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICoreTextServicesManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CoreTextServicesManager : ICoreTextServicesManager
  {
    public extern Language InputLanguage { [MethodImpl] get; }

    public extern event TypedEventHandler<CoreTextServicesManager, object> InputLanguageChanged;

    [MethodImpl]
    public extern CoreTextEditContext CreateEditContext();

    [MethodImpl]
    public static extern CoreTextServicesManager GetForCurrentView();
  }
}
