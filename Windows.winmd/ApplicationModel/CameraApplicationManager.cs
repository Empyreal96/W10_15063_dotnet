// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.CameraApplicationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICameraApplicationManagerStatics), 65536, "Windows.Phone.PhoneContract")]
  public static class CameraApplicationManager
  {
    [MethodImpl]
    public static extern void ShowInstalledApplicationsUI();
  }
}
