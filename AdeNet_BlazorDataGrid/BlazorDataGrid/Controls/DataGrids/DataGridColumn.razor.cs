using Microsoft.AspNetCore.Components;

namespace BlazorDataGrid.Controls.DataGrids
{
    public partial class DataGridColumn
    {
        #region Properties
        [CascadingParameter]
        DataGrid Owner { get; set; }

        [Parameter]
        public string Caption { get; set; }

        [Parameter]
        public int CellWidth { get; set; }
        #endregion

        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.Owner.RegisterColumn(this);
        }
    }
}