// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ISuspendingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2516982789, 11706, 19720, 176, 189, 43, 48, 161, 49, 198, 170)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISuspendingEventArgs
  {
    SuspendingOperation SuspendingOperation { get; }
  }
}
