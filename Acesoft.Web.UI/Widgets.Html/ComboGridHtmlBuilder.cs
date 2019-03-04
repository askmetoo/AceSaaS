using System.Collections.Generic;
using System.Linq;

namespace Acesoft.Web.UI.Widgets.Html
{
	public class ComboGridHtmlBuilder<Widget> : ComboHtmlBuilder<Widget> where Widget : ComboGrid
	{
		public ComboGridHtmlBuilder(Widget component)
			: base(component)
		{
		}

		protected override void PreBuild()
		{
			base.PreBuild();
			if (base.Component.TextField.HasValue())
			{
				base.Options["textField"] = base.Component.TextField;
			}
			if (base.Component.Mode.HasValue)
			{
				base.Options["mode"] = base.Component.Mode;
			}
			if (Enumerable.Any<IList<DataGridColumn>>((IEnumerable<IList<DataGridColumn>>)base.Component.Columns))
			{
				base.Options["columns"] = base.Component.Columns;
			}
			if (Enumerable.Any<DataGridColumn>((IEnumerable<DataGridColumn>)base.Component.FrozenColumns))
			{
				base.Options["frozenColumns"] = base.Component.FrozenColumns;
			}
			if (Enumerable.Any<LinkButton>((IEnumerable<LinkButton>)base.Component.Toolbar))
			{
				base.Options["toolbar"] = base.Component.Toolbar;
			}
			if (base.Component.FitColumns.HasValue)
			{
				base.Options["fitColumns"] = base.Component.FitColumns;
			}
			if (base.Component.ResizeHandle.HasValue)
			{
				base.Options["resizeHandle"] = base.Component.ResizeHandle;
			}
			if (base.Component.ResizeEdge.HasValue)
			{
				base.Options["resizeEdge"] = base.Component.ResizeEdge;
			}
			if (base.Component.AutoRowHeight.HasValue)
			{
				base.Options["autoRowHeight"] = base.Component.AutoRowHeight;
			}
			if (base.Component.Striped.HasValue)
			{
				base.Options["striped"] = base.Component.Striped;
			}
			if (base.Component.Nowrap.HasValue)
			{
				base.Options["nowrap"] = base.Component.Nowrap;
			}
			if (base.Component.IdField.HasValue())
			{
				base.Options["idField"] = base.Component.IdField;
			}
			if (base.Component.LoadMsg.HasValue())
			{
				base.Options["loadMsg"] = base.Component.LoadMsg;
			}
			if (base.Component.EmptyMsg.HasValue())
			{
				base.Options["emptyMsg"] = base.Component.EmptyMsg;
			}
			if (base.Component.Pagination.HasValue)
			{
				base.Options["pagination"] = base.Component.Pagination;
			}
			if (base.Component.Rownumbers.HasValue)
			{
				base.Options["rownumbers"] = base.Component.Rownumbers;
			}
			if (base.Component.SingleSelect.HasValue)
			{
				base.Options["singleSelect"] = base.Component.SingleSelect;
			}
			if (base.Component.CtrlSelect.HasValue)
			{
				base.Options["ctrlSelect"] = base.Component.CtrlSelect;
			}
			if (base.Component.CheckOnSelect.HasValue)
			{
				base.Options["checkOnSelect"] = base.Component.CheckOnSelect;
			}
			if (base.Component.SelectOnCheck.HasValue)
			{
				base.Options["selectOnCheck"] = base.Component.SelectOnCheck;
			}
			if (base.Component.ScrollOnSelect.HasValue)
			{
				base.Options["scrollOnSelect"] = base.Component.ScrollOnSelect;
			}
			if (base.Component.PagePosition.HasValue)
			{
				base.Options["pagePosition"] = base.Component.PagePosition;
			}
			if (base.Component.PageNumber.HasValue)
			{
				base.Options["pageNumber"] = base.Component.PageNumber;
			}
			if (base.Component.PageSize.HasValue)
			{
				base.Options["pageSize"] = base.Component.PageSize;
			}
			if (Enumerable.Any<int>((IEnumerable<int>)base.Component.PageList))
			{
				base.Options["pageList"] = base.Component.PageList;
			}
			if (base.Component.SortName.HasValue())
			{
				base.Options["sortName"] = base.Component.SortName;
			}
			if (base.Component.SortOrder.HasValue)
			{
				base.Options["sortOrder"] = base.Component.SortOrder;
			}
			if (base.Component.MultiSort.HasValue)
			{
				base.Options["multiSort"] = base.Component.MultiSort;
			}
			if (base.Component.RemoteSort.HasValue)
			{
				base.Options["remoteSort"] = base.Component.RemoteSort;
			}
			if (base.Component.ShowHeader.HasValue)
			{
				base.Options["showHeader"] = base.Component.ShowHeader;
			}
			if (base.Component.ShowFooter.HasValue)
			{
				base.Options["showFooter"] = base.Component.ShowFooter;
			}
			if (base.Component.ScrollbarSize.HasValue)
			{
				base.Options["scrollbarSize"] = base.Component.ScrollbarSize;
			}
			if (base.Component.RownumberWidth.HasValue)
			{
				base.Options["rownumberWidth"] = base.Component.RownumberWidth;
			}
			if (base.Component.EditorHeight.HasValue)
			{
				base.Options["editorHeight"] = base.Component.EditorHeight;
			}
		}
	}
}
