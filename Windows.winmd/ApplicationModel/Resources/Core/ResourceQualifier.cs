// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceQualifier
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ResourceQualifier : IResourceQualifier
  {
    public extern string QualifierName { [MethodImpl] get; }

    public extern string QualifierValue { [MethodImpl] get; }

    public extern bool IsDefault { [MethodImpl] get; }

    public extern bool IsMatch { [MethodImpl] get; }

    public extern double Score { [MethodImpl] get; }
  }
}
