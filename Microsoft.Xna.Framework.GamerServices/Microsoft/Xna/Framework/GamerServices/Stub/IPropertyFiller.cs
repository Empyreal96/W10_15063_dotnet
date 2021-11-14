// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.Stub.IPropertyFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

namespace Microsoft.Xna.Framework.GamerServices.Stub
{
  internal interface IPropertyFiller
  {
    void BeginFillData();

    void EndFillData();

    void SetValue(string key, string value);

    void SetValue(string key, int value);

    void SetValue(string key, float value);

    void SetValue(string key, double value);

    void SetValue(string key, long value);

    void SetNamedValue(GSPropertyName name, string value);

    void SetNamedValue(GSPropertyName name, int value);

    void SetNamedValue(GSPropertyName name, float value);

    void SetNamedValue(GSPropertyName name, double value);

    void SetNamedValue(GSPropertyName name, long value);

    bool TryGetValue(string key, out string value);

    bool TryGetValue(string key, out int value);

    bool TryGetValue(string key, out float value);

    bool TryGetValue(string key, out double value);

    bool TryGetValue(string key, out long value);

    bool TryGetNamedValue(GSPropertyName name, out string value);

    bool TryGetNamedValue(GSPropertyName name, out int value);

    bool TryGetNamedValue(GSPropertyName name, out float value);

    bool TryGetNamedValue(GSPropertyName name, out double value);

    bool TryGetNamedValue(GSPropertyName name, out long value);
  }
}
