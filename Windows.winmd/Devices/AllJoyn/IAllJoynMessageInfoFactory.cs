// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynMessageInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynMessageInfo))]
  [Guid(879119402, 33417, 17364, 180, 168, 63, 77, 227, 89, 240, 67)]
  internal interface IAllJoynMessageInfoFactory
  {
    AllJoynMessageInfo Create(string senderUniqueName);
  }
}
