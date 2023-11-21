
using Microsoft.AspNetCore.Components;

namespace Perseo.Scl.BackOffice.UI.Shared
{
    public partial class ActionsPage
    {
        [Parameter]
        public List<ActionGroup> ActionGroups { get; set; }
    }

    public class ActionGroup
    {
        public string Title { get; set; }
        public List<ActionItem> ActionItems { get; set; }

    }
    public class ActionItem
    {
        public string ItemName { get; set; }
        /// <summary>
        /// Marca si el botón está activo o no
        /// </summary>
        public bool ItemActive { get; set; }
        public string ItemIcon { get; set; }
        public bool ItemDissabled { get; set; }
        public EventCallback<ActionItem> OnClick { get; set; }
       public int ID { get; set; } = int.MinValue;
        public bool SubAction { get; set; }

       


        public List<SubActionGroup> SubActionGroup { get; set; }
    }

    public class SubActionGroup {
        public string SubActionGroupTitle { get; set; }
        public List<SubActionItem> SubActionItems { get; set; }
    }

    public class SubActionItem {
        public string SubItemName { get; set; }
        public string SubItemIcon { get; set; }
        public bool SubItemDissabled { get; set; }

        public EventCallback<SubActionItem> OnClick { get; set; }
    }
}
