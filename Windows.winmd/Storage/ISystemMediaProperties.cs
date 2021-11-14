// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemMediaProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(2754294550, 33813, 16604, 140, 68, 152, 54, 29, 35, 84, 48)]
  [ExclusiveTo(typeof (SystemMediaProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemMediaProperties
  {
    string Duration { get; }

    string Producer { get; }

    string Publisher { get; }

    string SubTitle { get; }

    string Writer { get; }

    string Year { get; }
  }
}
