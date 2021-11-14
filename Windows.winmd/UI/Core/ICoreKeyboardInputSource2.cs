// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreKeyboardInputSource2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4196715412, 63843, 18341, 135, 120, 32, 124, 72, 43, 10, 253)]
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  internal interface ICoreKeyboardInputSource2
  {
    string GetCurrentKeyEventDeviceId();
  }
}
