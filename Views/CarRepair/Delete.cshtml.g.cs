@model Samochodzik.Models.CarRepair

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>CarRepair</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(model => model.CarModel)
        </dt>
        <dd>
            @Html.DisplayFor(model => model.CarModel)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.CustomerName)
        </dt>
        <dd>
            @Html.DisplayFor(model => model.CustomerName)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.RepairDate)
        </dt>
        <dd>
            @Html.DisplayFor(model => model.RepairDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.Price)
        </dt>
        <dd>
            @Html.DisplayFor(model => model.Price)
        </dd>
    </dl>

    @using (Html.BeginForm())
    {
        <input type="submit" value="Delete" class="btn btn-danger" />
        @Html.ActionLink("Cancel", "Index", null, new { @class = "btn btn-default" })
    }
</div>
