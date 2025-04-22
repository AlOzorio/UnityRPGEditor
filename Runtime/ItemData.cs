using UnityEngine;
using Sirenix.OdinInspector;

namespace UnityRPGEditor
{
    public abstract class ItemData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField, TextArea]
        public string Description { get; private set; }

        [field: SerializeField, SuffixLabel("Gold", true)]
        public int Value { get; private set; }

        [field: SerializeField, SuffixLabel("Kg", true)]
        public float Weight { get; private set; }

        [field: SerializeField]
        public ItemRarity Rarity { get; private set; } = ItemRarity.Common;

        [field: SerializeField, PreviewField(Height = 50)]
        public Sprite Icon { get; private set; }
    }
}

public enum ItemRarity
{
    Junk,
    Common,
    Uncommon,
    Magic,
    Rare,
    Epic,
    Legendary,
    Mythic
}