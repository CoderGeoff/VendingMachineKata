using System;

namespace VendingMachine
{
    public class ButtonPad
    {
        private readonly Action m_SelectionChangedAction;
        private readonly Selection m_Selection = new Selection();
        public readonly IButton One;
        public readonly IButton Two;
        public readonly IButton Three;
        public readonly IButton Four;
        public readonly IButton Five;
        public readonly IButton Six;
        public readonly IButton ClearSelection;
        public readonly IButton ClearTransaction;

        public ButtonPad(Action clearTransaction, Action selectionChangedAction)
        {
            m_SelectionChangedAction = selectionChangedAction;
            One = new Button(() => OnButtonPress(1));
            Two = new Button(() => OnButtonPress(2));
            Three = new Button(() => OnButtonPress(3));
            Four = new Button(() => OnButtonPress(4));
            Five = new Button(() => OnButtonPress(5));
            Six = new Button(() => OnButtonPress(6));
            ClearSelection = new Button(() => {m_Selection.Clear(); selectionChangedAction();});
            ClearTransaction = new Button(clearTransaction);
        }

        private void OnButtonPress(int buttonId)
        {
            m_Selection.AddToSelection(buttonId);
            m_SelectionChangedAction();
        }

        public string GetCurrentSelection()
        {
            return m_Selection.CurrentSelection;
        }

    }
}