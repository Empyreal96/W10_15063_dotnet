// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceQualifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceQualifier))]
  [Guid(2019403186, 19197, 17270, 168, 136, 197, 249, 166, 183, 160, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceQualifier
  {
    string QualifierName { get; }

    string QualifierValue { get; }

    bool IsDefault { get; }

    bool IsMatch { get; }

    double Score { get; }
  }
}
