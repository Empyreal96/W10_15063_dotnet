// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IErrorDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (ErrorDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(931969793, 11465, 17039, 140, 85, 44, 153, 13, 70, 62, 143)]
  internal interface IErrorDetails
  {
    string Description { get; }

    string LongDescription { get; }

    Uri HelpUri { get; }
  }
}
