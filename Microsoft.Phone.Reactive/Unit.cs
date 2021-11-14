// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Unit
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Reactive
{
  [StructLayout(LayoutKind.Sequential, Size = 1)]
  public struct Unit : IEquatable<Unit>
  {
    public bool Equals(Unit other) => true;

    public override bool Equals(object obj) => obj is Unit;

    public override int GetHashCode() => 0;

    public static bool operator ==(Unit unit1, Unit unit2) => true;

    public static bool operator !=(Unit unit1, Unit unit2) => false;
  }
}
