// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IUnhandledErrorDetectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [Guid(1738192779, 45878, 18466, 172, 64, 13, 117, 15, 11, 122, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (UnhandledErrorDetectedEventArgs))]
  internal interface IUnhandledErrorDetectedEventArgs
  {
    UnhandledError UnhandledError { get; }
  }
}
