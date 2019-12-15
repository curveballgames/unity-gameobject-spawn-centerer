using UnityEngine;
using UnityEditor;

namespace UnityGameObjectCenterer {
    [CustomEditor(typeof(Transform))]
    internal class TransformEditor : Editor {
        void Awake() {
            Transform inspectedTransform = (Transform) target;

            if (inspectedTransform.GetComponent<GameObjectCenterer>() == null && EditorUtility.IsDirty(inspectedTransform)) {
                inspectedTransform.gameObject.AddComponent<GameObjectCenterer>();
            }
        }
    }
}
