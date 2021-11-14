// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynProducer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2634565241, 18075, 18778, 167, 16, 172, 80, 241, 35, 6, 159)]
  public interface IAllJoynProducer
  {
    void SetBusObject(AllJoynBusObject busObject);
  }
}
