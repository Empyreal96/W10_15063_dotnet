// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.CompleteName
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace Microsoft.Phone.UserData
{
  public sealed class CompleteName
  {
    public string FirstName { get; internal set; }

    public string YomiFirstName { get; internal set; }

    public string LastName { get; internal set; }

    public string YomiLastName { get; internal set; }

    public string MiddleName { get; internal set; }

    public string Title { get; internal set; }

    public string Nickname { get; internal set; }

    public string Suffix { get; internal set; }

    internal CompleteName()
    {
    }
  }
}
