using Microsoft.AspNetCore.Components;

namespace BlazorDataGrid.Controls.DataGrids
{
    public partial class DataGridRow
    {
        [Parameter]
        public Subject? Value { get; set; }

        [Parameter]
        public string? EditMode { get; set; }

        private string _strRowSelectStyle = string.Empty;

        private void RowSelect()
        {
            _strRowSelectStyle = _strRowSelectStyle == "focus" ? string.Empty : "focus";
        }
    }
}
