// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IInputEnabledEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InputEnabledEventArgs))]
  [Guid(2151095631, 12248, 19492, 170, 134, 49, 99, 168, 123, 78, 90)]
  [WebHostHidden]
  internal interface IInputEnabledEventArgs : ICoreWindowEventArgs
  {
    bool InputEnabled { get; }
  }
}
