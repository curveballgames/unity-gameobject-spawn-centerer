using UnityEngine;

namespace UnityGameObjectCenterer {
    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class GameObjectCenterer : MonoBehaviour {
        [SerializeField]
        [HideInInspector]
        private bool initialised = false;

        void Awake() {
            if (initialised) {
                return;
            }

            // destroy when distributed outside the Unity Editor
            if (!Application.isEditor) {
                DestroyImmediate(this);
                return;
            }

            transform.localPosition = Vector3.zero;
            initialised = true;
        }
    }
}
