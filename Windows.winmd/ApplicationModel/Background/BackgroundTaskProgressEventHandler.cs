// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1189111868, 35464, 19609, 128, 76, 118, 137, 127, 98, 119, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void BackgroundTaskProgressEventHandler(
    BackgroundTaskRegistration sender,
    BackgroundTaskProgressEventArgs args);
}
