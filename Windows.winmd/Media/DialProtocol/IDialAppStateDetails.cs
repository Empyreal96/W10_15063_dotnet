// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialAppStateDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DialAppStateDetails))]
  [Guid(3720651937, 62942, 16397, 190, 164, 140, 132, 102, 187, 41, 97)]
  internal interface IDialAppStateDetails
  {
    DialAppState State { get; }

    string FullXml { get; }
  }
}
