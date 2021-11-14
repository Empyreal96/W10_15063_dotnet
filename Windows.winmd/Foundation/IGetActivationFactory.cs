// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IGetActivationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(1323011810, 38621, 18855, 148, 247, 70, 7, 221, 171, 142, 60)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IGetActivationFactory
  {
    object GetActivationFactory(string activatableClassId);
  }
}
