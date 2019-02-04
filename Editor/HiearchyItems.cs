using UnityEngine;
using UnityEditor;

namespace GameplayIngredients
{
    static class HiearchyItems
    {
        #region TRIGGERS

        [MenuItem("GameObject/GameplayIngredients/Events/Trigger (Box)", false, 10)]
        static void CreateTriggerBox()
        {
            var go = new GameObject();
            var col = go.AddComponent<BoxCollider>();
            col.isTrigger = true;
            var evt = go.AddComponent<Events.OnTriggerEvent>();
            go.name = "Box Trigger";

            if (Selection.activeGameObject != null)
                go.transform.parent = Selection.activeGameObject.transform;
        }

        [MenuItem("GameObject/GameplayIngredients/Events/Trigger (Sphere)", false, 10)]
        static void CreateTriggerSphere()
        {
            var go = new GameObject();
            var col = go.AddComponent<SphereCollider>();
            col.isTrigger = true;
            var evt = go.AddComponent<Events.OnTriggerEvent>();
            go.name = "Sphere Trigger";

            if (Selection.activeGameObject != null)
                go.transform.parent = Selection.activeGameObject.transform;
        }

        [MenuItem("GameObject/GameplayIngredients/Events/Trigger (Capsule)", false, 10)]
        static void CreateTriggerCapsule()
        {
            var go = new GameObject();
            var col = go.AddComponent<CapsuleCollider>();
            col.isTrigger = true;
            var evt = go.AddComponent<Events.OnTriggerEvent>();
            go.name = "Capsule Trigger";

            if (Selection.activeGameObject != null)
                go.transform.parent = Selection.activeGameObject.transform;
        }

        [MenuItem("GameObject/GameplayIngredients/Events/On Awake", false, 10)]
        static void CreateOnAwake()
        {
            var go = new GameObject();
            var evt = go.AddComponent<Events.OnAwakeEvent>();
            go.name = "On Awake";

            if (Selection.activeGameObject != null)
                go.transform.parent = Selection.activeGameObject.transform;
        }

        [MenuItem("GameObject/GameplayIngredients/Events/On Enable/Disable", false, 10)]
        static void CreateOnEnableDisable()
        {
            var go = new GameObject();
            var evt = go.AddComponent<Events.OnEnableDisableEvent>();
            go.name = "On Enable/Disable";

            if (Selection.activeGameObject != null)
                go.transform.parent = Selection.activeGameObject.transform;
        }

        #endregion

    }
}

