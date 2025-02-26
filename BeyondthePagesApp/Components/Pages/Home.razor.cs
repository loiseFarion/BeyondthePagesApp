using BeyondthePagesApp.Components.Widgets;

namespace BeyondthePagesApp.Components.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>() { typeof(EmployeeCountWidget), typeof(InboxWidget) };
    }
}
