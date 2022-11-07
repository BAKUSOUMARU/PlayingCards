using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CardAutoSet))]
[CanEditMultipleObjects]
internal class CardEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var manager = target as CardAutoSet;

        if (GUILayout.Button("set"))
        {
            var _cardList = new CardList();
            CardList cardList = Resources.Load<CardList>("Aseets/CardList");
            manager.CardSet(_cardList);
            EditorUtility.SetDirty( _cardList);
            AssetDatabase.SaveAssets();
            Debug.Log("èIÇÌÇ¡ÇΩ");
        }
    }
}
