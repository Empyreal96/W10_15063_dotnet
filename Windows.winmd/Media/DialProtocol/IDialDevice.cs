// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialDevice))]
  [Guid(4293979567, 30111, 16850, 162, 10, 127, 41, 206, 11, 55, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDialDevice
  {
    string Id { get; }

    DialApp GetDialApp(string appName);
  }
}
