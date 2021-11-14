// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ModelBone
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelBone
  {
    private string name;
    internal Matrix transform;
    private int index;
    private ModelBone parent;
    private ModelBoneCollection children;

    public string Name => this.name;

    public int Index => this.index;

    public Matrix Transform
    {
      get => this.transform;
      set => this.transform = value;
    }

    public ModelBone Parent => this.parent;

    public ModelBoneCollection Children => this.children;

    internal ModelBone(string name, Matrix transform, int index)
    {
      this.name = name;
      this.transform = transform;
      this.index = index;
    }

    internal void SetParentAndChildren(ModelBone newParent, ModelBone[] newChildren)
    {
      this.parent = newParent;
      this.children = new ModelBoneCollection(newChildren);
    }
  }
}
