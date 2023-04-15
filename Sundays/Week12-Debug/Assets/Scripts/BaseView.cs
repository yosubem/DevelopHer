using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public abstract class BaseView : MonoBehaviour
    {
        protected delegate void OnClickedHandler(Action clickedFunction);

        protected event OnClickedHandler ButtonClickedEvent;

        void Start()
        {
            gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            onClickInternal();
            ButtonClickedEvent?.Invoke(OnClick);
        }

        protected abstract void onClickInternal();
    }
}