// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3628731410, 23695, 17292, 131, 203, 194, 143, 204, 11, 47, 219)]
  public interface IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData : 
    IActivatedEventArgs
  {
    string CallerPackageFamilyName { get; }

    ValueSet Data { get; }
  }
}
