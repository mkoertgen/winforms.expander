using System.ComponentModel;
using System.Windows.Forms.Design;

namespace WinFormsExpander
{
    public class ExpanderDesigner : ParentControlDesigner
    {
        private Expander _expander;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            _expander = (Expander) Control;
            EnableDesignMode(_expander.Content, "Content");
        }
    }
}