﻿@model Samochodzik.Models.CarRepair

<h2>Create</h2>

<form asp-action="Create">
    <div class="form-group">
        <label asp-for="CarModel"></label>
        <input asp-for="CarModel" class="form-control" />
    </div>
    <div class="form-group">
        <label asp-for="CustomerName"></label>
        <input asp-for="CustomerName" class="form-control" />
    </div>
    <div class="form-group">
        <label asp-for="RepairDate"></label>
        <input asp-for="RepairDate" class="form-control" />
    </div>
    <div class="form-group">
        <label asp-for="Price"></label>
        <input asp-for="Price" class="form-control" />
    </div>
    <button type="submit" class="btn btn-primary">Create</button>
</form>
