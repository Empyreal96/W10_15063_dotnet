// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.KeyboardState
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.Input
{
  public struct KeyboardState
  {
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask0 = uint.MaxValue;
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask1 = uint.MaxValue;
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask2 = uint.MaxValue;
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask3 = uint.MaxValue;
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask4 = uint.MaxValue;
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask5 = uint.MaxValue;
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask6 = uint.MaxValue;
    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline", Justification = "Windows platform requires the static ctor")]
    private static uint stateMask7 = uint.MaxValue;
    private uint currentState0;
    private uint currentState1;
    private uint currentState2;
    private uint currentState3;
    private uint currentState4;
    private uint currentState5;
    private uint currentState6;
    private uint currentState7;

    [SuppressMessage("Microsoft.Usage", "CA2207:InitializeValueTypeStaticFieldsInline")]
    static KeyboardState()
    {
      KeyboardState keyboardState = new KeyboardState();
      foreach (int allKey in Keyboard.AllKeys)
        keyboardState.AddPressedKey(allKey);
      KeyboardState.stateMask0 = keyboardState.currentState0;
      KeyboardState.stateMask1 = keyboardState.currentState1;
      KeyboardState.stateMask2 = keyboardState.currentState2;
      KeyboardState.stateMask3 = keyboardState.currentState3;
      KeyboardState.stateMask4 = keyboardState.currentState4;
      KeyboardState.stateMask5 = keyboardState.currentState5;
      KeyboardState.stateMask6 = keyboardState.currentState6;
      KeyboardState.stateMask7 = keyboardState.currentState7;
    }

    public KeyboardState(params Keys[] keys)
    {
      this.currentState0 = this.currentState1 = this.currentState2 = this.currentState3 = this.currentState4 = this.currentState5 = this.currentState6 = this.currentState7 = 0U;
      if (keys == null)
        return;
      for (int index = 0; index < keys.Length; ++index)
        this.AddPressedKey((int) keys[index]);
    }

    internal void AddPressedKey(int key)
    {
      uint num = (uint) (1 << key);
      switch (key >> 5)
      {
        case 0:
          this.currentState0 |= num & KeyboardState.stateMask0;
          break;
        case 1:
          this.currentState1 |= num & KeyboardState.stateMask1;
          break;
        case 2:
          this.currentState2 |= num & KeyboardState.stateMask2;
          break;
        case 3:
          this.currentState3 |= num & KeyboardState.stateMask3;
          break;
        case 4:
          this.currentState4 |= num & KeyboardState.stateMask4;
          break;
        case 5:
          this.currentState5 |= num & KeyboardState.stateMask5;
          break;
        case 6:
          this.currentState6 |= num & KeyboardState.stateMask6;
          break;
        case 7:
          this.currentState7 |= num & KeyboardState.stateMask7;
          break;
      }
    }

    internal void RemovePressedKey(int key)
    {
      uint num = (uint) (1 << key);
      switch (key >> 5)
      {
        case 0:
          this.currentState0 &= (uint) ~((int) num & (int) KeyboardState.stateMask0);
          break;
        case 1:
          this.currentState1 &= (uint) ~((int) num & (int) KeyboardState.stateMask1);
          break;
        case 2:
          this.currentState2 &= (uint) ~((int) num & (int) KeyboardState.stateMask2);
          break;
        case 3:
          this.currentState3 &= (uint) ~((int) num & (int) KeyboardState.stateMask3);
          break;
        case 4:
          this.currentState4 &= (uint) ~((int) num & (int) KeyboardState.stateMask4);
          break;
        case 5:
          this.currentState5 &= (uint) ~((int) num & (int) KeyboardState.stateMask5);
          break;
        case 6:
          this.currentState6 &= (uint) ~((int) num & (int) KeyboardState.stateMask6);
          break;
        case 7:
          this.currentState7 &= (uint) ~((int) num & (int) KeyboardState.stateMask7);
          break;
      }
    }

    public KeyState this[Keys key]
    {
      get
      {
        uint num1;
        switch ((int) key >> 5)
        {
          case 0:
            num1 = this.currentState0;
            break;
          case 1:
            num1 = this.currentState1;
            break;
          case 2:
            num1 = this.currentState2;
            break;
          case 3:
            num1 = this.currentState3;
            break;
          case 4:
            num1 = this.currentState4;
            break;
          case 5:
            num1 = this.currentState5;
            break;
          case 6:
            num1 = this.currentState6;
            break;
          case 7:
            num1 = this.currentState7;
            break;
          default:
            return KeyState.Up;
        }
        uint num2 = 1U << (int) (key & (Keys) 31 & (Keys) 31);
        return ((int) num1 & (int) num2) == 0 ? KeyState.Up : KeyState.Down;
      }
    }

    public bool IsKeyDown(Keys key) => this[key] == KeyState.Down;

    public bool IsKeyUp(Keys key) => this[key] == KeyState.Up;

    public Keys[] GetPressedKeys()
    {
      int index1 = 0;
      KeyboardState.CheckPressedKeys(this.currentState0, 0, (Keys[]) null, ref index1);
      KeyboardState.CheckPressedKeys(this.currentState1, 0, (Keys[]) null, ref index1);
      KeyboardState.CheckPressedKeys(this.currentState2, 0, (Keys[]) null, ref index1);
      KeyboardState.CheckPressedKeys(this.currentState3, 0, (Keys[]) null, ref index1);
      KeyboardState.CheckPressedKeys(this.currentState4, 0, (Keys[]) null, ref index1);
      KeyboardState.CheckPressedKeys(this.currentState5, 0, (Keys[]) null, ref index1);
      KeyboardState.CheckPressedKeys(this.currentState6, 0, (Keys[]) null, ref index1);
      KeyboardState.CheckPressedKeys(this.currentState7, 0, (Keys[]) null, ref index1);
      Keys[] pressedKeys = new Keys[index1];
      if (index1 > 0)
      {
        int index2 = 0;
        KeyboardState.CheckPressedKeys(this.currentState0, 0, pressedKeys, ref index2);
        KeyboardState.CheckPressedKeys(this.currentState1, 1, pressedKeys, ref index2);
        KeyboardState.CheckPressedKeys(this.currentState2, 2, pressedKeys, ref index2);
        KeyboardState.CheckPressedKeys(this.currentState3, 3, pressedKeys, ref index2);
        KeyboardState.CheckPressedKeys(this.currentState4, 4, pressedKeys, ref index2);
        KeyboardState.CheckPressedKeys(this.currentState5, 5, pressedKeys, ref index2);
        KeyboardState.CheckPressedKeys(this.currentState6, 6, pressedKeys, ref index2);
        KeyboardState.CheckPressedKeys(this.currentState7, 7, pressedKeys, ref index2);
      }
      return pressedKeys;
    }

    private static void CheckPressedKeys(
      uint packedState,
      int packedOffset,
      Keys[] pressedKeys,
      ref int index)
    {
      if (packedState == 0U)
        return;
      for (int index1 = 0; index1 < 32; ++index1)
      {
        if (((long) packedState & (long) (1 << index1)) != 0L)
        {
          if (pressedKeys != null)
            pressedKeys[index] = (Keys) (packedOffset * 32 + index1);
          ++index;
        }
      }
    }

    public override int GetHashCode() => this.currentState0.GetHashCode() ^ this.currentState1.GetHashCode() ^ this.currentState2.GetHashCode() ^ this.currentState3.GetHashCode() ^ this.currentState4.GetHashCode() ^ this.currentState5.GetHashCode() ^ this.currentState6.GetHashCode() ^ this.currentState7.GetHashCode();

    public override bool Equals(object obj) => obj is KeyboardState keyboardState && this == keyboardState;

    public static bool operator ==(KeyboardState a, KeyboardState b) => (int) a.currentState0 == (int) b.currentState0 && (int) a.currentState1 == (int) b.currentState1 && ((int) a.currentState2 == (int) b.currentState2 && (int) a.currentState3 == (int) b.currentState3) && ((int) a.currentState4 == (int) b.currentState4 && (int) a.currentState5 == (int) b.currentState5 && (int) a.currentState6 == (int) b.currentState6) && (int) a.currentState7 == (int) b.currentState7;

    public static bool operator !=(KeyboardState a, KeyboardState b) => !(a == b);
  }
}
