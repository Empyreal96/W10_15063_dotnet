// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IKeyEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(1480252824, 1936, 17777, 155, 18, 100, 94, 249, 215, 158, 66)]
  [ExclusiveTo(typeof (KeyEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IKeyEventArgs2 : ICoreWindowEventArgs
  {
    string DeviceId { get; }
  }
}
