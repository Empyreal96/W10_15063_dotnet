// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynMessageInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynMessageInfo))]
  [Guid(4281008423, 11282, 18521, 170, 58, 199, 68, 97, 238, 129, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynMessageInfo
  {
    string SenderUniqueName { get; }
  }
}
