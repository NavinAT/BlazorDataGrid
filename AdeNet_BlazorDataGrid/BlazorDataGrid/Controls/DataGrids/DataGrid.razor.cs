using Microsoft.AspNetCore.Components;

namespace BlazorDataGrid.Controls.DataGrids
{
    public partial class DataGrid
    {
        #region Fields
        private readonly List<DataGridColumn> Columns = new();
        #endregion

        #region Properties
        [Parameter]
        public IEnumerable<Subject>? DataSource { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string EditMode { get; set; }

        [Parameter]
        public bool DynamicWidth { get; set; }

        #endregion

        protected override void OnInitialized()
        {

        }

        #region Publics
        public void RegisterColumn(DataGridColumn column)
        {
            Columns.Add(column);
            StateHasChanged();
        }

        private string BuildGridStyle()
        {
            string strWidthStyle = this.DynamicWidth ? "dynamic-width" : "";
            return $"datagrid-table {strWidthStyle}";
        }

        private string BuildContainerStyle()
        {
            string strEditModeStyle = this.EditMode == "R" ? "readonly" : "editable\"";
            return $"datagrid {strEditModeStyle}";
        }
        #endregion
    }
}