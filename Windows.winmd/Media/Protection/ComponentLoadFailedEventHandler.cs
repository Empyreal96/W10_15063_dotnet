// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ComponentLoadFailedEventHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2514117692, 28089, 16971, 134, 202, 9, 26, 244, 50, 8, 28)]
  public delegate void ComponentLoadFailedEventHandler(
    MediaProtectionManager sender,
    ComponentLoadFailedEventArgs e);
}
