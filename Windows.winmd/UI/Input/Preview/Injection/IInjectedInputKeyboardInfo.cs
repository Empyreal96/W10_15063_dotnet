// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputKeyboardInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Guid(1262932288, 11114, 24570, 126, 174, 189, 7, 123, 5, 42, 205)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InjectedInputKeyboardInfo))]
  internal interface IInjectedInputKeyboardInfo
  {
    InjectedInputKeyOptions KeyOptions { get; set; }

    ushort ScanCode { get; set; }

    ushort VirtualKey { get; set; }
  }
}
