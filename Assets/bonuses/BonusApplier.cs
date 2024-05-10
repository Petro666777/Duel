using System.Collections.Generic;
using UnityEngine;

public interface BonusApplier
{
    public abstract void ApplyBonus(List<BonusType> existingBonusTypes, GameObject root);
}