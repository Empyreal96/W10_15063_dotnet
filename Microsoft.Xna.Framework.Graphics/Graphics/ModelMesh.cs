// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ModelMesh
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelMesh
  {
    private string name;
    private ModelBone parentBone;
    private BoundingSphere boundingSphere;
    private ModelMeshPartCollection meshParts;
    private ModelEffectCollection effects = new ModelEffectCollection();
    private object tag;

    internal ModelMesh(
      string name,
      ModelBone parentBone,
      BoundingSphere boundingSphere,
      ModelMeshPart[] meshParts,
      object tag)
    {
      this.name = name;
      this.parentBone = parentBone;
      this.boundingSphere = boundingSphere;
      this.meshParts = new ModelMeshPartCollection(meshParts);
      this.tag = tag;
      int length = meshParts.Length;
      for (int index = 0; index < length; ++index)
        meshParts[index].parent = this;
    }

    public string Name => this.name;

    public ModelBone ParentBone => this.parentBone;

    public BoundingSphere BoundingSphere => this.boundingSphere;

    public object Tag
    {
      get => this.tag;
      set => this.tag = value;
    }

    public ModelMeshPartCollection MeshParts => this.meshParts;

    public ModelEffectCollection Effects => this.effects;

    public void Draw()
    {
      int count1 = this.MeshParts.Count;
      for (int index1 = 0; index1 < count1; ++index1)
      {
        ModelMeshPart meshPart = this.MeshParts[index1];
        Effect effect = meshPart.Effect;
        if (effect == null)
          throw new InvalidOperationException(FrameworkResources.ModelHasNoEffect);
        int count2 = effect.CurrentTechnique.Passes.Count;
        for (int index2 = 0; index2 < count2; ++index2)
        {
          effect.CurrentTechnique.Passes[index2].Apply();
          meshPart.Draw();
        }
      }
    }
  }
}
