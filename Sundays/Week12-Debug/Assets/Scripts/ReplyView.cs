using System;
using System.Collections.Generic;
using DefaultNamespace;


public class ReplyView : BaseView
{
    private Stack<Action> _clickedActions = new Stack<Action>();
    void Awake()
    {
        ButtonClickedEvent += OnAnyOtherButtonClicked;
    }

    protected override void onClickInternal()
    {
        if (_clickedActions.Count > 0) {
            Action LastButtonClicked = _clickedActions.Pop();
            LastButtonClicked();
        }
    }

    void OnAnyOtherButtonClicked(Action clickedFunc)
    {
        _clickedActions.Push(clickedFunc);
    }
}
