@model IEnumerable<Samochodzik.Models.CarRepair>

@{
    ViewData["Title"] = "Index";
}

<h2>Index</h2>

<p>
    <a asp-action="Create">Create New</a>
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.CarModel)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.CustomerName)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.RepairDate)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Price)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model)
        {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem => item.CarModel)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.CustomerName)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.RepairDate)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Price)
                </td>
                <td>
                    <a asp-action="Edit" asp-route-id="@item.CarRepairID">Edit</a> |
                    <a asp-action="Details" asp-route-id="@item.CarRepairID">Details</a> |
                    <a asp-action="Delete" asp-route-id="@item.CarRepairID">Delete</a>
                </td>
            </tr>
        }
    </tbody>
</table>