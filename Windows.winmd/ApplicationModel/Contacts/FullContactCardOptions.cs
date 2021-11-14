// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.FullContactCardOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FullContactCardOptions : IFullContactCardOptions
  {
    [MethodImpl]
    public extern FullContactCardOptions();

    public extern ViewSizePreference DesiredRemainingView { [MethodImpl] get; [MethodImpl] set; }
  }
}
