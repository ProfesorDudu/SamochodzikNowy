@model Samochodzik.Models.CarRepair

<h2>Details</h2>

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
</div>
